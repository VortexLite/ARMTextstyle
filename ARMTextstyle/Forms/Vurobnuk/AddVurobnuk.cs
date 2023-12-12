using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMTextstyle.Forms.Vurobnuk
{
    public partial class AddVurobnuk : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public AddVurobnuk()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void AddVurobnuk_Load(object sender, EventArgs e)
        {
            IDNakladnoi.Items.Clear();
            var cmd = new SqlCommand("SELECT kod_nakladnoi, kilkist, zina, data_postachana\r\nFROM nakladna", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string kilkist = reader.GetInt32(1).ToString();
                string zina = reader.GetDecimal(2).ToString();
                string dataPostachann = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                string comboBoxItem = $"{id} {kilkist} {zina} {dataPostachann}";
                IDNakladnoi.Items.Add(comboBoxItem);
            }
            reader.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(postachalnuk.Text) &&
                !string.IsNullOrEmpty(kontaktu.Text) &&
                !string.IsNullOrEmpty(IDNakladnoi.Text))
            {
                string id = "";
                var command = new SqlCommand("SELECT MAX(CAST(kod_postacalnuka AS INT)) AS max_id FROM vurobnuk", connection);
                try
                {
                    id = Convert.ToString(Convert.ToInt32(command.ExecuteScalar().ToString()) + 1);
                }
                catch
                {
                    id = "1";
                }

                string combotxt = IDNakladnoi.Text;
                string[] words = combotxt.Split(' ');
                string idNakladnoi = words[0];

                var cmd = new SqlCommand("AddVurobnuk", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nazva_postacalnuka", postachalnuk.Text);
                cmd.Parameters.AddWithValue("@kontakt_postacalnuka", kontaktu.Text);
                cmd.Parameters.AddWithValue("@kod_nakladnoi", idNakladnoi);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Виробник добавлений", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка у добавлені даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
