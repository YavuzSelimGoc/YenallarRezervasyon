
namespace YenallarRezervasyon
{
    partial class FrmMusteriRezervasyon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.mtxtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelNo = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.BtnOnayla = new System.Windows.Forms.Button();
            this.BtnSonraki = new System.Windows.Forms.Button();
            this.txttc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad-Soyad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC No: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefon No : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mail : ";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(167, 35);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(274, 26);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // mtxtTcNo
            // 
            this.mtxtTcNo.Location = new System.Drawing.Point(94, 273);
            this.mtxtTcNo.Mask = "00000000000";
            this.mtxtTcNo.Name = "mtxtTcNo";
            this.mtxtTcNo.Size = new System.Drawing.Size(274, 26);
            this.mtxtTcNo.TabIndex = 3;
            this.mtxtTcNo.ValidatingType = typeof(int);
            // 
            // mtxtTelNo
            // 
            this.mtxtTelNo.Location = new System.Drawing.Point(167, 118);
            this.mtxtTelNo.Mask = "(999) 000-0000";
            this.mtxtTelNo.Name = "mtxtTelNo";
            this.mtxtTelNo.Size = new System.Drawing.Size(274, 26);
            this.mtxtTelNo.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(167, 160);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(274, 26);
            this.txtMail.TabIndex = 4;
            // 
            // BtnOnayla
            // 
            this.BtnOnayla.Location = new System.Drawing.Point(7, 231);
            this.BtnOnayla.Name = "BtnOnayla";
            this.BtnOnayla.Size = new System.Drawing.Size(84, 40);
            this.BtnOnayla.TabIndex = 36;
            this.BtnOnayla.Text = "Onayla";
            this.BtnOnayla.UseVisualStyleBackColor = true;
            this.BtnOnayla.Click += new System.EventHandler(this.BtnOnayla_Click);
            // 
            // BtnSonraki
            // 
            this.BtnSonraki.Location = new System.Drawing.Point(301, 231);
            this.BtnSonraki.Name = "BtnSonraki";
            this.BtnSonraki.Size = new System.Drawing.Size(163, 40);
            this.BtnSonraki.TabIndex = 35;
            this.BtnSonraki.Text = "Sonraki";
            this.BtnSonraki.UseVisualStyleBackColor = true;
            this.BtnSonraki.Click += new System.EventHandler(this.BtnSonraki_Click);
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(167, 80);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(274, 26);
            this.txttc.TabIndex = 37;
            // 
            // FrmMusteriRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 311);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.BtnOnayla);
            this.Controls.Add(this.BtnSonraki);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.mtxtTelNo);
            this.Controls.Add(this.mtxtTcNo);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMusteriRezervasyon";
            this.Text = "FrmMusteriRezervasyon";
            this.Load += new System.EventHandler(this.FrmMusteriRezervasyon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.MaskedTextBox mtxtTcNo;
        private System.Windows.Forms.MaskedTextBox mtxtTelNo;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button BtnOnayla;
        private System.Windows.Forms.Button BtnSonraki;
        private System.Windows.Forms.TextBox txttc;
    }
}