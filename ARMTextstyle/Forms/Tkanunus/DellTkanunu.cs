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

namespace ARMTextstyle.Forms.Tkanunus
{
    public partial class DellTkanunu : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public DellTkanunu()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void DellTkanunu_Load(object sender, EventArgs e)
        {
            ComboBox1.Items.Clear();
            var cmd = new SqlCommand("SELECT artycul, nazva_tkanunu, shilnist\r\nFROM tkanunu", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string nazva = reader.GetString(1);
                string shilnist = reader.GetString(2);
                string comboBoxItem = $"{id} {nazva} {shilnist}";
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
                var cmd = new SqlCommand("DellTkanunu", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                ComboBox1.Items.Remove(ComboBox1.SelectedItem);
                MessageBox.Show("Тканини видалено", "Успіх", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Помилка у видаленні", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
