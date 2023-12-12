using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMTextstyle.Forms.Chek
{
    public partial class AddChek : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public AddChek()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void AddChek_Load(object sender, EventArgs e)
        {
            IDKasur.Items.Clear();
            var cmd = new SqlCommand("SELECT code_kasury, surname, nazva\r\nFROM kasur", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string surname = reader.GetString(1);
                string nazva = reader.GetString(2);
                string comboBoxItem = $"{id} {surname} {nazva}";
                IDKasur.Items.Add(comboBoxItem);
            }
            reader.Close();

            IDTkanunu.Items.Clear();
            cmd = new SqlCommand("SELECT artycul, nazva_tkanunu, shilnist\r\nFROM tkanunu", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string nazva = reader.GetString(1);
                string shilnist = reader.GetString(2);
                string comboBoxItem = $"{id} {nazva} {shilnist}";
                IDTkanunu.Items.Add(comboBoxItem);
            }
            reader.Close();

            DateProdazhy.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(kilkist.Text) &&
                !string.IsNullOrEmpty(Price.Text) &&
                !string.IsNullOrEmpty(IDKasur.Text) &&
                !string.IsNullOrEmpty(IDTkanunu.Text))
            {
                string id = "";
                var command = new SqlCommand("SELECT MAX(CAST(chek_number AS INT)) AS max_id FROM chek", connection);
                try
                {
                    id = Convert.ToString(Convert.ToInt32(command.ExecuteScalar().ToString()) + 1);
                }
                catch
                {
                    id = "1";
                }

                string combotxt = IDKasur.Text;
                string[] words = combotxt.Split(' ');
                string idKasur = words[0];

                string combotxt1 = IDTkanunu.Text;
                string[] words1 = combotxt1.Split(' ');
                string idTkanunu = words1[0];

                var cmd = new SqlCommand("AddChek", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@kilkist", kilkist.Text);
                cmd.Parameters.AddWithValue("@price", Price.Text);
                cmd.Parameters.AddWithValue("@data_prodazhy", DateProdazhy.Text);
                cmd.Parameters.AddWithValue("@code_kasury", idKasur);
                cmd.Parameters.AddWithValue("@artycul", idTkanunu);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Чек виданий", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка у друку чеку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
