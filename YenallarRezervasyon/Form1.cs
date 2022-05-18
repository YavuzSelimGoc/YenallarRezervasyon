using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YenallarRezervasyon
{
    public partial class FrmUlasimRezervasyon : Form
    {
        UlasimRezManager rezervasyon = new UlasimRezManager(new Fact_Otobus_Cadir());
        public int MusteriID;
        
        public FrmUlasimRezervasyon()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = rezervasyon.GetListAll();
            //MessageBox.Show(MusteriID.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ulasim ulasim = new Ulasim();
            ulasim.GidisTarih = Convert.ToDateTime( dtgidis.Value.ToString());
            ulasim.DonusTarih = Convert.ToDateTime( dtdonus.Value.ToString());
            ulasim.Fiyat = Convert.ToInt32(txtKisiSayisi.Text);
            ulasim.FirmaAdi = txtFirmaAdi.Text;
            ulasim.MusteriID = Convert.ToInt32(MusteriID);
            ulasim.UlasimTuru = "Otobus-Cadir";
            rezervasyon.Insert(ulasim);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Ulasim ulasim = new Ulasim();
          //  ulasim.UlasimId = Convert.ToInt32( txtID.Text);
            //ulasim.GidisTarih = Convert.ToDateTime(dtgidis.Value.ToString());
            //ulasim.DonusTarih = Convert.ToDateTime(dtdonus.Value.ToString());
            //ulasim.Fiyat = Convert.ToInt32(txtFiyat.Text);
            //ulasim.FirmaAdi = txtFirmaAdi.Text;
            //rezervasyon.Update(ulasim);
            List<Ulasim> ulasims = new List<Ulasim>();
            ulasims.Add(rezervasyon.GetById(ulasim.UlasimId));
            //dataGridView1.DataSource = ulasims;
        }

        private void txtFirmaAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgidis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            FrmOtobusCadir fr = new FrmOtobusCadir();
            fr.Show();
            this.Hide();
        }

        private void BtnOnayla_Click(object sender, EventArgs e)
        {
            Ulasim ulasim = new Ulasim();
            ulasim.GidisTarih = Convert.ToDateTime(dtgidis.Value.ToString());
            ulasim.DonusTarih = Convert.ToDateTime(dtdonus.Value.ToString());
            ulasim.Fiyat = Convert.ToInt32(txtKisiSayisi.Text);
            ulasim.FirmaAdi = txtFirmaAdi.Text;
            ulasim.MusteriID = 1;//Convert.ToInt32( telno);
            ulasim.UlasimTuru = comboBox1.Text;
            rezervasyon.Insert(ulasim);
        }
    }
}
