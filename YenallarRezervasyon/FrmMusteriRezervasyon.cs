using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YenallarRezervasyon
{
    public partial class FrmMusteriRezervasyon : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        MusteriManager MusteriManager = new MusteriManager();
        public int MusteriId;
        public FrmMusteriRezervasyon()
        {
            InitializeComponent();
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            bgl.baglanti().Close();
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("select MusteriID from Musteri Where TcKimlikNo=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1",txttc.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                MusteriId = Convert.ToInt32(dr[0]);
            }
            MessageBox.Show("ds : " + MusteriId);
            dr.Close();
            bgl.baglanti().Close();
            FrmUlasimRezervasyon form1 = new FrmUlasimRezervasyon();
            form1.MusteriID =  MusteriId;
            form1.Show();
            this.Hide();
        }

        private void BtnOnayla_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.AdiSoyadi = txtAdSoyad.Text;
            musteri.TcKimlikNo = txttc.Text;
            musteri.TelefonNo = mtxtTelNo.Text;
            musteri.Mail = txtMail.Text;
            MusteriManager.Insert(musteri);
            
        }

        private void FrmMusteriRezervasyon_Load(object sender, EventArgs e)
        {

        }
    }
}
