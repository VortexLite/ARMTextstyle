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

namespace ARMTextstyle.Forms.Chek
{
    public partial class DellChek : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public DellChek()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void DellChek_Load(object sender, EventArgs e)
        {
            ComboBox1.Items.Clear();
            var cmd = new SqlCommand("select chek_number, data_prodazhy, kasur.surname, kasur.nazva\r\nfrom chek\r\ninner join kasur on chek.code_kasury = kasur.code_kasury", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string dateprod = reader.GetDateTime(1).ToString("yyyy-MM-dd");
                string surname = reader.GetString(2);
                string name = reader.GetString(3);
                string comboBoxItem = $"{id} {dateprod} {surname} {name}";
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
                var cmd = new SqlCommand("DellChek", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                ComboBox1.Items.Remove(ComboBox1.SelectedItem);
                MessageBox.Show("Чек видалено", "Успіх", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Помилка у видаленні", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
