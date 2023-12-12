using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ARMTextstyle.Forms.Tkanunus
{
    public partial class AddTkanunus : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public AddTkanunus()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void AddTkanunus_Load(object sender, EventArgs e)
        {
            IDMAterial.Items.Clear();
            var cmd = new SqlCommand("SELECT kod_material, nazva_material, opus\r\nFROM material", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string nazva = reader.GetString(1);
                string opus = reader.GetString(2);
                string comboBoxItem = $"{id} {nazva} {opus}";
                IDMAterial.Items.Add(comboBoxItem);
            }
            reader.Close();

            IDPruznachenya.Items.Clear();
            cmd = new SqlCommand("SELECT kod_pruznachenya, nazva_pruznachenya\r\nFROM pruznachenya", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string nazva = reader.GetString(1);
                string comboBoxItem = $"{id} {nazva}";
                IDPruznachenya.Items.Add(comboBoxItem);
            }
            reader.Close();

            IDKolir.Items.Clear();
            cmd = new SqlCommand("SELECT kod_kolory, nazva_kolory\r\nFROM kolir", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string nazva = reader.GetString(1);
                string comboBoxItem = $"{id} {nazva}";
                IDKolir.Items.Add(comboBoxItem);
            }
            reader.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Shilnist.Text) &&
                !string.IsNullOrEmpty(Nazva_tkanunu.Text) &&
                !string.IsNullOrEmpty(IDMAterial.Text) &&
                !string.IsNullOrEmpty(IDPruznachenya.Text) &&
                !string.IsNullOrEmpty(IDKolir.Text))
            {
                string id = "";
                var command = new SqlCommand("SELECT MAX(CAST(artycul AS INT)) AS max_id FROM tkanunu", connection);
                try
                {
                    id = Convert.ToString(Convert.ToInt32(command.ExecuteScalar().ToString()) + 1);
                }
                catch
                {
                    id = "1";
                }

                string combotxt = IDMAterial.Text;
                string[] words = combotxt.Split(' ');
                string idMat = words[0];

                string combotxt1 = IDPruznachenya.Text;
                string[] words1 = combotxt1.Split(' ');
                string idPruz = words1[0];

                string combotxt2 = IDKolir.Text;
                string[] words2 = combotxt2.Split(' ');
                string idKolir = words2[0];

                var cmd = new SqlCommand("AddTkanunu", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@shilnist", Shilnist.Text);
                cmd.Parameters.AddWithValue("@nazva_tkanunu", Nazva_tkanunu.Text);
                cmd.Parameters.AddWithValue("@kod_material", idMat);
                cmd.Parameters.AddWithValue("@kod_pruznachenya", idPruz);
                cmd.Parameters.AddWithValue("@kod_kolory", idKolir);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Тканини добавлені", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка у введені даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
