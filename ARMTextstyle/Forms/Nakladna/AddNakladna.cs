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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ARMTextstyle.Forms.Nakladna
{
    public partial class AddNakladna : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public AddNakladna()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void AddNakladna_Load(object sender, EventArgs e)
        {
            IDTkanunu.Items.Clear();
            var cmd = new SqlCommand("SELECT artycul, nazva_tkanunu, shilnist\r\nFROM tkanunu", connection);
            SqlDataReader reader = cmd.ExecuteReader();
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
                !string.IsNullOrEmpty(IDTkanunu.Text))
            {
                string id = "";
                var command = new SqlCommand("SELECT MAX(CAST(kod_nakladnoi AS INT)) AS max_id FROM nakladna", connection);
                try
                {
                    id = Convert.ToString(Convert.ToInt32(command.ExecuteScalar().ToString()) + 1);
                }
                catch
                {
                    id = "1";
                }

                string combotxt = IDTkanunu.Text;
                string[] words = combotxt.Split(' ');
                string idTkanunu = words[0];

                var cmd = new SqlCommand("AddNakladna", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@kilkist", kilkist.Text);
                cmd.Parameters.AddWithValue("@zina", Price.Text);
                cmd.Parameters.AddWithValue("@data_postachana", DateProdazhy.Text);
                cmd.Parameters.AddWithValue("@artycul", idTkanunu);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Накладна створена", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка створенні накладній", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
