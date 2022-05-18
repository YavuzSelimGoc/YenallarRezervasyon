using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YenallarRezervasyon
{
    public partial class Login : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public Login()
        {
            InitializeComponent();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select * from Musteri where Mail=@p1 and Sifre=@p2", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txtMail.Text);
            kmt.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                FrmUlasimRezervasyon form1 = new FrmUlasimRezervasyon();
                form1.MusteriID = Convert.ToInt32( dr[0]);
                form1.Show();
            }
        }
    }
}
