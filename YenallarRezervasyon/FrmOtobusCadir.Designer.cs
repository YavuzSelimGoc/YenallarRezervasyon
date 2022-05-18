
namespace YenallarRezervasyon
{
    partial class FrmOtobusCadir
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
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtCikis = new System.Windows.Forms.DateTimePicker();
            this.dtGiris = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnOnayla = new System.Windows.Forms.Button();
            this.BtnSonraki = new System.Windows.Forms.Button();
            this.txtKisiSayisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Çıkış Tarihi :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(52, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Giriş Tarihi :";
            // 
            // dtCikis
            // 
            this.dtCikis.Location = new System.Drawing.Point(158, 113);
            this.dtCikis.Margin = new System.Windows.Forms.Padding(5);
            this.dtCikis.Name = "dtCikis";
            this.dtCikis.Size = new System.Drawing.Size(294, 26);
            this.dtCikis.TabIndex = 26;
            // 
            // dtGiris
            // 
            this.dtGiris.Location = new System.Drawing.Point(158, 73);
            this.dtGiris.Margin = new System.Windows.Forms.Padding(5);
            this.dtGiris.Name = "dtGiris";
            this.dtGiris.Size = new System.Drawing.Size(294, 26);
            this.dtGiris.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Kişi Sayısı:";
            // 
            // BtnOnayla
            // 
            this.BtnOnayla.Location = new System.Drawing.Point(49, 183);
            this.BtnOnayla.Name = "BtnOnayla";
            this.BtnOnayla.Size = new System.Drawing.Size(84, 40);
            this.BtnOnayla.TabIndex = 34;
            this.BtnOnayla.Text = "Onayla";
            this.BtnOnayla.UseVisualStyleBackColor = true;
            this.BtnOnayla.Click += new System.EventHandler(this.BtnOnayla_Click);
            // 
            // BtnSonraki
            // 
            this.BtnSonraki.Location = new System.Drawing.Point(198, 183);
            this.BtnSonraki.Name = "BtnSonraki";
            this.BtnSonraki.Size = new System.Drawing.Size(239, 40);
            this.BtnSonraki.TabIndex = 33;
            this.BtnSonraki.Text = "Rezervasyonu Tamamla";
            this.BtnSonraki.UseVisualStyleBackColor = true;
            this.BtnSonraki.Click += new System.EventHandler(this.BtnSonraki_Click);
            // 
            // txtKisiSayisi
            // 
            this.txtKisiSayisi.Location = new System.Drawing.Point(158, 24);
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.Size = new System.Drawing.Size(294, 26);
            this.txtKisiSayisi.TabIndex = 35;
            // 
            // FrmOtobusCadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 272);
            this.Controls.Add(this.txtKisiSayisi);
            this.Controls.Add(this.BtnOnayla);
            this.Controls.Add(this.BtnSonraki);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtCikis);
            this.Controls.Add(this.dtGiris);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOtobusCadir";
            this.Text = "FrmKonaklamaRezervasyon";
            this.Load += new System.EventHandler(this.FrmKonaklamaRezervasyon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtCikis;
        private System.Windows.Forms.DateTimePicker dtGiris;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnOnayla;
        private System.Windows.Forms.Button BtnSonraki;
        private System.Windows.Forms.TextBox txtKisiSayisi;
    }
}