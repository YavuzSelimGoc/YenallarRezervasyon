
namespace YenallarRezervasyon
{
    partial class FrmUlasimRezervasyon
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
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.dtgidis = new System.Windows.Forms.DateTimePicker();
            this.dtdonus = new System.Windows.Forms.DateTimePicker();
            this.txtKisiSayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnSonraki = new System.Windows.Forms.Button();
            this.BtnOnayla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(134, 44);
            this.txtFirmaAdi.Margin = new System.Windows.Forms.Padding(5);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(211, 26);
            this.txtFirmaAdi.TabIndex = 1;
            this.txtFirmaAdi.TextChanged += new System.EventHandler(this.txtFirmaAdi_TextChanged);
            // 
            // dtgidis
            // 
            this.dtgidis.Location = new System.Drawing.Point(134, 80);
            this.dtgidis.Margin = new System.Windows.Forms.Padding(5);
            this.dtgidis.Name = "dtgidis";
            this.dtgidis.Size = new System.Drawing.Size(294, 26);
            this.dtgidis.TabIndex = 2;
            this.dtgidis.ValueChanged += new System.EventHandler(this.dtgidis_ValueChanged);
            // 
            // dtdonus
            // 
            this.dtdonus.Location = new System.Drawing.Point(134, 120);
            this.dtdonus.Margin = new System.Windows.Forms.Padding(5);
            this.dtdonus.Name = "dtdonus";
            this.dtdonus.Size = new System.Drawing.Size(294, 26);
            this.dtdonus.TabIndex = 3;
            // 
            // txtKisiSayisi
            // 
            this.txtKisiSayisi.Location = new System.Drawing.Point(134, 167);
            this.txtKisiSayisi.Margin = new System.Windows.Forms.Padding(5);
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.Size = new System.Drawing.Size(211, 26);
            this.txtKisiSayisi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Firma Adı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gidiş Tarihi :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dönüş Tarihi :";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fiyat : ";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ucak-otel",
            "ucak-cadir",
            "otobüs-otel",
            "otobüs-cadir"});
            this.comboBox1.Location = new System.Drawing.Point(122, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 28);
            this.comboBox1.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(130, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Ulasim ve Konaklama Türü seç";
            // 
            // BtnSonraki
            // 
            this.BtnSonraki.Location = new System.Drawing.Point(306, 290);
            this.BtnSonraki.Name = "BtnSonraki";
            this.BtnSonraki.Size = new System.Drawing.Size(163, 40);
            this.BtnSonraki.TabIndex = 27;
            this.BtnSonraki.Text = "Sonraki";
            this.BtnSonraki.UseVisualStyleBackColor = true;
            this.BtnSonraki.Click += new System.EventHandler(this.BtnSonraki_Click);
            // 
            // BtnOnayla
            // 
            this.BtnOnayla.Location = new System.Drawing.Point(12, 290);
            this.BtnOnayla.Name = "BtnOnayla";
            this.BtnOnayla.Size = new System.Drawing.Size(84, 40);
            this.BtnOnayla.TabIndex = 28;
            this.BtnOnayla.Text = "Onayla";
            this.BtnOnayla.UseVisualStyleBackColor = true;
            this.BtnOnayla.Click += new System.EventHandler(this.BtnOnayla_Click);
            // 
            // FrmUlasimRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 354);
            this.Controls.Add(this.BtnOnayla);
            this.Controls.Add(this.BtnSonraki);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKisiSayisi);
            this.Controls.Add(this.dtdonus);
            this.Controls.Add(this.dtgidis);
            this.Controls.Add(this.txtFirmaAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmUlasimRezervasyon";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.DateTimePicker dtgidis;
        private System.Windows.Forms.DateTimePicker dtdonus;
        private System.Windows.Forms.TextBox txtKisiSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnSonraki;
        private System.Windows.Forms.Button BtnOnayla;
    }
}

