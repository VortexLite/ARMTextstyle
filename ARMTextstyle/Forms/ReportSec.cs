using ARMTextstyle.Forms.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMTextstyle.Forms
{
    public partial class ReportSec : Form
    {
        public ReportSec()
        {
            InitializeComponent();
        }

        private void ReportSec_Load(object sender, EventArgs e)
        {
            ComboBox1.Items.Clear();
            ComboBox1.Items.Add("Всі тканини");
            ComboBox1.Items.Add("Перелік чеків");

            ComboBox1.SelectedIndex = 0;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            switch (ComboBox1.SelectedItem)
            {
                case "Всі тканини":
                    var RepTkanunu = new AllTkanunu();
                    RepTkanunu.ShowDialog();
                    break;

                case "Перелік чеків":
                    var RepChekiv = new PerelikChekiv();
                    RepChekiv.ShowDialog();
                    break;
            }
        }
    }
}
