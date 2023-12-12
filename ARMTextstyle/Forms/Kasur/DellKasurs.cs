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

namespace ARMTextstyle.Forms.Kasur
{
    public partial class DellKasurs : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public DellKasurs()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void DellKasurs_Load(object sender, EventArgs e)
        {
            ComboBox1.Items.Clear();
            var cmd = new SqlCommand("SELECT code_kasury, surname, nazva\r\nFROM kasur", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string surname = reader.GetString(1);
                string name = reader.GetString(2);
                string comboBoxItem = $"{id} {surname} {name}";
                ComboBox1.Items.Add(comboBoxItem);
            }
            reader.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            string combotxt = ComboBox1.Text;
            string[] words2 = combotxt.Split(' ');
            string id = words2[0];

            if (ComboBox1.SelectedItem != null)
            {
                var cmd = new SqlCommand("DellKasur", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                ComboBox1.Items.Remove(ComboBox1.SelectedItem);
                MessageBox.Show("Касира звільнено", "Успіх", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Помилка у звільнені касира", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
