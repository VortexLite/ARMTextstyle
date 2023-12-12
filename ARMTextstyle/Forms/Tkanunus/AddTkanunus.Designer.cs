namespace ARMTextstyle.Forms.Tkanunus
{
    partial class AddTkanunus
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
            this.OKBtn = new System.Windows.Forms.Button();
            this.Nazva_tkanunu = new System.Windows.Forms.TextBox();
            this.Shilnist = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDMAterial = new System.Windows.Forms.ComboBox();
            this.IDPruznachenya = new System.Windows.Forms.ComboBox();
            this.IDKolir = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OKBtn
            // 
            this.OKBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKBtn.Location = new System.Drawing.Point(55, 260);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(395, 43);
            this.OKBtn.TabIndex = 39;
            this.OKBtn.Text = "Добавити";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // Nazva_tkanunu
            // 
            this.Nazva_tkanunu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazva_tkanunu.Location = new System.Drawing.Point(220, 78);
            this.Nazva_tkanunu.Name = "Nazva_tkanunu";
            this.Nazva_tkanunu.Size = new System.Drawing.Size(230, 26);
            this.Nazva_tkanunu.TabIndex = 37;
            // 
            // Shilnist
            // 
            this.Shilnist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shilnist.Location = new System.Drawing.Point(220, 41);
            this.Shilnist.Name = "Shilnist";
            this.Shilnist.Size = new System.Drawing.Size(230, 26);
            this.Shilnist.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(51, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Код матеріалу";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(51, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Назва тканини";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(51, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Щільність";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 319);
            this.label1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(51, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Код призначення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(51, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Код кольору";
            // 
            // IDMAterial
            // 
            this.IDMAterial.FormattingEnabled = true;
            this.IDMAterial.Location = new System.Drawing.Point(220, 127);
            this.IDMAterial.Name = "IDMAterial";
            this.IDMAterial.Size = new System.Drawing.Size(230, 24);
            this.IDMAterial.TabIndex = 43;
            // 
            // IDPruznachenya
            // 
            this.IDPruznachenya.FormattingEnabled = true;
            this.IDPruznachenya.Location = new System.Drawing.Point(220, 164);
            this.IDPruznachenya.Name = "IDPruznachenya";
            this.IDPruznachenya.Size = new System.Drawing.Size(230, 24);
            this.IDPruznachenya.TabIndex = 44;
            // 
            // IDKolir
            // 
            this.IDKolir.FormattingEnabled = true;
            this.IDKolir.Location = new System.Drawing.Point(220, 206);
            this.IDKolir.Name = "IDKolir";
            this.IDKolir.Size = new System.Drawing.Size(230, 24);
            this.IDKolir.TabIndex = 45;
            // 
            // AddTkanunus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(497, 371);
            this.Controls.Add(this.IDKolir);
            this.Controls.Add(this.IDPruznachenya);
            this.Controls.Add(this.IDMAterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.Nazva_tkanunu);
            this.Controls.Add(this.Shilnist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "AddTkanunus";
            this.Text = "Добавити тканини";
            this.Load += new System.EventHandler(this.AddTkanunus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.TextBox Nazva_tkanunu;
        private System.Windows.Forms.TextBox Shilnist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IDMAterial;
        private System.Windows.Forms.ComboBox IDPruznachenya;
        private System.Windows.Forms.ComboBox IDKolir;
    }
}