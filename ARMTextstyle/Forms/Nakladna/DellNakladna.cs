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

namespace ARMTextstyle.Forms.Nakladna
{
    public partial class DellNakladna : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public DellNakladna()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void DellNakladna_Load(object sender, EventArgs e)
        {
            ComboBox1.Items.Clear();
            var cmd = new SqlCommand("SELECT kod_nakladnoi, kilkist, data_postachana\r\nFROM nakladna", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string kilkist = reader.GetInt32(1).ToString();
                string dateprod = reader.GetDateTime(2).ToString("yyyy-MM-dd");
                string comboBoxItem = $"{id} {kilkist} {dateprod}";
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
                var cmd = new SqlCommand("DellNakladna", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                ComboBox1.Items.Remove(ComboBox1.SelectedItem);
                MessageBox.Show("Накладна видалено", "Успіх", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Помилка у видаленні", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
