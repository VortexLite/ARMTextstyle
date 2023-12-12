namespace ARMTextstyle
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ViewMenu = new System.Windows.Forms.Button();
            this.ControlBtn = new System.Windows.Forms.Button();
            this.Rep = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.TextLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStripView = new System.Windows.Forms.MenuStrip();
            this.Tkanunu = new System.Windows.Forms.ToolStripMenuItem();
            this.material = new System.Windows.Forms.ToolStripMenuItem();
            this.kolir = new System.Windows.Forms.ToolStripMenuItem();
            this.vurobnuk = new System.Windows.Forms.ToolStripMenuItem();
            this.nakladna = new System.Windows.Forms.ToolStripMenuItem();
            this.chek = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStripView.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewMenu
            // 
            this.ViewMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewMenu.Location = new System.Drawing.Point(4, 101);
            this.ViewMenu.Name = "ViewMenu";
            this.ViewMenu.Size = new System.Drawing.Size(114, 31);
            this.ViewMenu.TabIndex = 0;
            this.ViewMenu.Text = "Перегляд";
            this.ViewMenu.UseVisualStyleBackColor = true;
            this.ViewMenu.Click += new System.EventHandler(this.ViewMenu_Click);
            // 
            // ControlBtn
            // 
            this.ControlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlBtn.Location = new System.Drawing.Point(4, 147);
            this.ControlBtn.Name = "ControlBtn";
            this.ControlBtn.Size = new System.Drawing.Size(114, 31);
            this.ControlBtn.TabIndex = 1;
            this.ControlBtn.Text = "Управління";
            this.ControlBtn.UseVisualStyleBackColor = true;
            this.ControlBtn.Click += new System.EventHandler(this.ControlBtn_Click);
            // 
            // Rep
            // 
            this.Rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rep.Location = new System.Drawing.Point(4, 193);
            this.Rep.Name = "Rep";
            this.Rep.Size = new System.Drawing.Size(114, 31);
            this.Rep.TabIndex = 2;
            this.Rep.Text = "Звіти";
            this.Rep.UseVisualStyleBackColor = true;
            this.Rep.Click += new System.EventHandler(this.Rep_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(4, 393);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(114, 31);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Вихід";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // TextLabel
            // 
            this.TextLabel.BackColor = System.Drawing.Color.SlateBlue;
            this.TextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel.ForeColor = System.Drawing.Color.Transparent;
            this.TextLabel.Location = new System.Drawing.Point(-1, -1);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(802, 51);
            this.TextLabel.TabIndex = 4;
            this.TextLabel.Text = "Перегляд";
            this.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.menuStripView);
            this.panel1.Location = new System.Drawing.Point(124, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 407);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStripView
            // 
            this.menuStripView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tkanunu,
            this.material,
            this.kolir,
            this.vurobnuk,
            this.nakladna,
            this.chek});
            this.menuStripView.Location = new System.Drawing.Point(0, 0);
            this.menuStripView.Name = "menuStripView";
            this.menuStripView.Size = new System.Drawing.Size(677, 28);
            this.menuStripView.TabIndex = 1;
            this.menuStripView.Text = "menuStrip1";
            // 
            // Tkanunu
            // 
            this.Tkanunu.Name = "Tkanunu";
            this.Tkanunu.Size = new System.Drawing.Size(82, 24);
            this.Tkanunu.Text = "Тканини";
            this.Tkanunu.Click += new System.EventHandler(this.TkanunuView_Click);
            // 
            // material
            // 
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(96, 24);
            this.material.Text = "Матеріали";
            this.material.Click += new System.EventHandler(this.MaterialView_Click);
            // 
            // kolir
            // 
            this.kolir.Name = "kolir";
            this.kolir.Size = new System.Drawing.Size(145, 24);
            this.kolir.Text = "Кольори тканини";
            this.kolir.Click += new System.EventHandler(this.KolirView_Click);
            // 
            // vurobnuk
            // 
            this.vurobnuk.Name = "vurobnuk";
            this.vurobnuk.Size = new System.Drawing.Size(102, 24);
            this.vurobnuk.Text = "Виробники";
            this.vurobnuk.Click += new System.EventHandler(this.VurobnukView_Click);
            // 
            // nakladna
            // 
            this.nakladna.Name = "nakladna";
            this.nakladna.Size = new System.Drawing.Size(86, 24);
            this.nakladna.Text = "Накладні";
            this.nakladna.Click += new System.EventHandler(this.NakladnaView_Click);
            // 
            // chek
            // 
            this.chek.Name = "chek";
            this.chek.Size = new System.Drawing.Size(57, 24);
            this.chek.Text = "Чеки";
            this.chek.Click += new System.EventHandler(this.ChekView_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Rep);
            this.Controls.Add(this.ControlBtn);
            this.Controls.Add(this.ViewMenu);
            this.MainMenuStrip = this.menuStripView;
            this.Name = "Form2";
            this.Text = "АРМ продавця текстильного магазину";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStripView.ResumeLayout(false);
            this.menuStripView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewMenu;
        private System.Windows.Forms.Button ControlBtn;
        private System.Windows.Forms.Button Rep;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStripView;
        private System.Windows.Forms.ToolStripMenuItem Tkanunu;
        private System.Windows.Forms.ToolStripMenuItem material;
        private System.Windows.Forms.ToolStripMenuItem kolir;
        private System.Windows.Forms.ToolStripMenuItem vurobnuk;
        private System.Windows.Forms.ToolStripMenuItem nakladna;
        private System.Windows.Forms.ToolStripMenuItem chek;
    }
}