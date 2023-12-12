using ARMTextstyle.Forms;
using ARMTextstyle.Forms.Chek;
using ARMTextstyle.Forms.Kasur;
using ARMTextstyle.Forms.Nakladna;
using ARMTextstyle.Forms.Tkanunus;
using ARMTextstyle.Forms.Vurobnuk;
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

namespace ARMTextstyle
{
    public partial class Form2 : Form
    {
        private string enter;
        private ConnectionDB dbconnection;
        private SqlConnection connection;

        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        public Form2(string enter)
        {
            InitializeComponent();
            this.enter = enter;
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
            dataGridView1.Hide();

            if (enter != "vlasnuk")
            {
                Rep.Visible = false;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool hasOpenForms = Application.OpenForms.Cast<Form>().Any(form => form.Visible);

            // Якщо немає відкритих форм, закриваємо програму
            if (!hasOpenForms)
            {
                Application.Exit();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var auth = new Form1();
            this.Hide();
            auth.ShowDialog();
        }

        private void ViewMenu_Click(object sender, EventArgs e)
        {
            TextLabel.Text = ViewMenu.Text;

            menuStripView.Items.Clear();
            dataGridView1.ClearSelection();
            dataGridView1.Show();

            ViewMenuStrip();
        }

        private void ViewMenuStrip()
        {
            ToolStripMenuItem tkanunuView = new ToolStripMenuItem("Тканини");
            ToolStripMenuItem materialView = new ToolStripMenuItem("Матеріали");
            ToolStripMenuItem kolirView = new ToolStripMenuItem("Кольори тканини");
            ToolStripMenuItem vurobnukView = new ToolStripMenuItem("Виробники");
            ToolStripMenuItem nakladnaView = new ToolStripMenuItem("Накладні");
            ToolStripMenuItem chekView = new ToolStripMenuItem("Чеки");

            menuStripView.Items.Add(tkanunuView);
            menuStripView.Items.Add(materialView);
            menuStripView.Items.Add(kolirView);
            menuStripView.Items.Add(vurobnukView);
            menuStripView.Items.Add(nakladnaView);
            menuStripView.Items.Add(chekView);

            tkanunuView.Click += TkanunuView_Click;
            materialView.Click += MaterialView_Click;
            kolirView.Click += KolirView_Click;
            vurobnukView.Click += VurobnukView_Click;
            nakladnaView.Click += NakladnaView_Click;
            chekView.Click += ChekView_Click;
        }

        private void TkanunuView_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("SELECT * FROM All_tkanunu_pokaz", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "All_tkanunu_pokaz");

            dataGridView1.DataSource = dataSet.Tables["All_tkanunu_pokaz"];
        }

        private void MaterialView_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("SELECT kod_material as [ID], nazva_material as [Назва матеріала], opus as [Опис] \r\nFROM material", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "material");

            dataGridView1.DataSource = dataSet.Tables["material"];
        }

        private void KolirView_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("SELECT kod_kolory as [ID], nazva_kolory as [Назва кольору]\r\nFROM kolir", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "kolir");

            dataGridView1.DataSource = dataSet.Tables["kolir"];
        }

        private void VurobnukView_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("SELECT kod_postacalnuka as [ID], nazva_postacalnuka as [Назва постачальника],\r\nkontakt_postacalnuka as [Контакт], kod_nakladnoi as [ID_накладної]\r\nFROM vurobnuk", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "vurobnuk");

            dataGridView1.DataSource = dataSet.Tables["vurobnuk"];
        }

        private void NakladnaView_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("SELECT kod_nakladnoi as [ID], kilkist as [Кількість], zina as [Ціна],\r\ndata_postachana as [Дата_постачання], artycul as [ID_тканини]\r\nFROM nakladna", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "nakladna");

            dataGridView1.DataSource = dataSet.Tables["nakladna"];
        }

        private void ChekView_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("SELECT chek_number as [ID], kilkist as [Кількість], price as [Ціна],\r\ndata_prodazhy as [Дата_продажу], code_kasury as [ID_касира], artycul as [ID_тканини]\r\nFROM chek", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "chek");

            dataGridView1.DataSource = dataSet.Tables["chek"];
        }

        private void ControlBtn_Click(object sender, EventArgs e)
        {
            TextLabel.Text = ControlBtn.Text;

            menuStripView.Items.Clear();
            dataGridView1.ClearSelection();
            dataGridView1.Hide();

            ControlmenuStrip();
        }

        private void ControlmenuStrip()
        {
            if (enter == "vlasnuk")
            {
                ToolStripMenuItem kasurControl = new ToolStripMenuItem("Касир");
                ToolStripMenuItem tkanunuControl = new ToolStripMenuItem("Тканини");
                ToolStripMenuItem chekControl = new ToolStripMenuItem("Чек");
                ToolStripMenuItem nakladnaControl = new ToolStripMenuItem("Накладна");
                ToolStripMenuItem vurobnukControl = new ToolStripMenuItem("Виробник");

                ToolStripMenuItem AddKasur = new ToolStripMenuItem("Найняти касира");
                ToolStripMenuItem DellKasur = new ToolStripMenuItem("Звільнити касира");
                ToolStripMenuItem AddTkanunu = new ToolStripMenuItem("Додати тканини");
                ToolStripMenuItem DellTkanunu = new ToolStripMenuItem("Видалити тканини");
                ToolStripMenuItem AddChek = new ToolStripMenuItem("Створити чек");
                ToolStripMenuItem DellChek = new ToolStripMenuItem("Видалити чек");
                ToolStripMenuItem AddNakladna = new ToolStripMenuItem("Створити накладну");
                ToolStripMenuItem DellNakladna = new ToolStripMenuItem("Видалити накладну");
                ToolStripMenuItem AddVurobnuk = new ToolStripMenuItem("Додати виробника");
                ToolStripMenuItem DellVurobnuk = new ToolStripMenuItem("Видалити виробника");

                kasurControl.DropDownItems.Add(AddKasur);
                kasurControl.DropDownItems.Add(DellKasur);
                tkanunuControl.DropDownItems.Add(AddTkanunu);
                tkanunuControl.DropDownItems.Add(DellTkanunu);
                chekControl.DropDownItems.Add(AddChek);
                chekControl.DropDownItems.Add(DellChek);
                nakladnaControl.DropDownItems.Add(AddNakladna);
                nakladnaControl.DropDownItems.Add(DellNakladna);
                vurobnukControl.DropDownItems.Add(AddVurobnuk);
                vurobnukControl.DropDownItems.Add(DellVurobnuk);

                menuStripView.Items.Add(kasurControl);
                menuStripView.Items.Add(tkanunuControl);
                menuStripView.Items.Add(chekControl);
                menuStripView.Items.Add(nakladnaControl);
                menuStripView.Items.Add(vurobnukControl);

                AddKasur.Click += AddKasur_Click;
                DellKasur.Click += DellKasur_Click;
                AddTkanunu.Click += AddTkanunu_Click;
                DellTkanunu.Click += DellTkanunu_Click;
                AddChek.Click += AddChek_Click;
                DellChek.Click += DellChek_Click;
                AddNakladna.Click += AddNakladna_Click;
                DellNakladna.Click += DellNakladna_Click;
                AddVurobnuk.Click += AddVurobnuk_Click;
                DellVurobnuk.Click += DellVurobnuk_Click;
            }
            else
            {
                ToolStripMenuItem chekControl = new ToolStripMenuItem("Чек");
                ToolStripMenuItem AddChek = new ToolStripMenuItem("Створити чек");
                chekControl.DropDownItems.Add(AddChek);
                menuStripView.Items.Add(chekControl);
                AddChek.Click += AddChek_Click;
            }
            
        }

        private void AddKasur_Click(object sender, EventArgs e)
        {
            var addKasur = new AddKasurs();
            addKasur.ShowDialog();
        }

        private void DellKasur_Click(object sender, EventArgs e)
        {
            var dellKasur = new DellKasurs();
            dellKasur.ShowDialog();
        }

        private void AddTkanunu_Click(object sender, EventArgs e)
        {
            var addTkanunu = new AddTkanunus();
            addTkanunu.ShowDialog();
        }

        private void DellTkanunu_Click(object sender, EventArgs e)
        {
            var dellTkanunu = new DellTkanunu();
            dellTkanunu.ShowDialog();
        }

        private void AddChek_Click(object sender, EventArgs e)
        {
            var addChek = new AddChek();
            addChek.ShowDialog();
        }

        private void DellChek_Click(object sender, EventArgs e)
        {
            var dellChek = new DellChek();
            dellChek.ShowDialog();
        }

        private void AddNakladna_Click(object sender, EventArgs e)
        {
            var addNakladna = new AddNakladna();
            addNakladna.ShowDialog();
        }

        private void DellNakladna_Click(object sender, EventArgs e)
        {
            var dellNakladna = new DellNakladna();
            dellNakladna.ShowDialog();
        }

        private void AddVurobnuk_Click(object sender, EventArgs e)
        {
            var addVurobnuk = new AddVurobnuk();
            addVurobnuk.ShowDialog();
        }

        private void DellVurobnuk_Click(object sender, EventArgs e)
        {
            var dellVurobnuk = new DellVurobnuk();
            dellVurobnuk.ShowDialog();
        }

        private void Rep_Click(object sender, EventArgs e)
        {
            var SelectReport = new ReportSec();
            SelectReport.ShowDialog();
        }
    }
}
