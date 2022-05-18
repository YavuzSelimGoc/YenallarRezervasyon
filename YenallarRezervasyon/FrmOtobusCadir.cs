using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YenallarRezervasyon
{
    public partial class FrmOtobusCadir : Form
    {
        KonaklamaRezManager KonaklamaRezManager = new KonaklamaRezManager(new Fact_Otobus_Cadir());
        
        public string TelNo;
        public FrmOtobusCadir()
        {
            InitializeComponent();
        }
        
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rezervasyon İşlmeleriniz Başarılı Bir Şekilde Gerçekleşmiştir");
            FrmRezervasyonGoruntule fr = new FrmRezervasyonGoruntule();
            fr.Show();
            this.Hide();
        }

        private void FrmKonaklamaRezervasyon_Load(object sender, EventArgs e)
        {
            MessageBox.Show(TelNo);
        }

        private void BtnOnayla_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt32(txtKisiSayisi.Text) * 150;
            Konaklama konaklama = new Konaklama();
            konaklama.GirisTarihi = Convert.ToDateTime(dtGiris.Value.ToString());
            konaklama.CikisTarihi = Convert.ToDateTime(dtCikis.Value.ToString());
            konaklama.KisiSayisi = Convert.ToInt32( txtKisiSayisi.Text);
            konaklama.Fiyat = fiyat;
            konaklama.MusteriID = 1;
            konaklama.TelNo = this.TelNo;
        }
    }
}
