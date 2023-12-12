using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMTextstyle
{
    public partial class Form1 : Form
    {
        private ConnectionDB dbconnection;
        public Form1()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
        }

        private void Auth_Click(object sender, EventArgs e)
        {
            if (dbconnection.Connect(Login.Text, Pass.Text))
            {
                MessageBox.Show("Підключення до бази даних встановлено успішно!", "Успіх", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                var main = new Form2(Login.Text);
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Помилка підключення", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool hasOpenForms = Application.OpenForms.Cast<Form>().Any(form => form.Visible);

            // Якщо немає відкритих форм, закриваємо програму
            if (!hasOpenForms)
            {
                Application.Exit();
            }
        }
    }
}
