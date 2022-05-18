using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YenallarRezervasyon
{
    public class KonaklamaRezManager:IKonaklamaService
    {
        private AbstractRezervasyonFactory _abstractRezervasyonFactory;
        private IKonaklama _konaklama;
        Konaklama k = new Konaklama();
        SqlBaglanti bgl = new SqlBaglanti();
        public KonaklamaRezManager(AbstractRezervasyonFactory abstractRezervasyonFactory)
        {
            _abstractRezervasyonFactory = abstractRezervasyonFactory;
            _konaklama = abstractRezervasyonFactory.KonaklamaOlustur(k);
        }

        public void Create(Konaklama entity)
        {
            throw new NotImplementedException();
        }

        public Konaklama GetById(int id)
        {
            Konaklama konaklama = new Konaklama();
            SqlCommand kmt = new SqlCommand("select*from Konaklama where KonaklamaID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr2 = kmt.ExecuteReader();
            while (dr2.Read())
            {
                konaklama.KonaklamaId = Convert.ToInt32(dr2[0]);
                konaklama.GirisTarihi = Convert.ToDateTime(dr2[1]);
                konaklama.CikisTarihi = Convert.ToDateTime(dr2[2]);
                konaklama.KisiSayisi = Convert.ToInt32(dr2[3].ToString());
                konaklama.Fiyat = Convert.ToDecimal(dr2[4]);
            }
            dr2.Close();
            bgl.baglanti().Close();
            return konaklama;
        }

        public List<Konaklama> GetListAll()
        {
            List<Konaklama> konaklamas = new List<Konaklama>();

            SqlCommand kmt = new SqlCommand("select*from Konaklama", bgl.baglanti());
            SqlDataReader dr2 = kmt.ExecuteReader();
            while (dr2.Read())
            {
                Konaklama konaklama = new Konaklama();
                konaklama.KonaklamaId = Convert.ToInt32(dr2[0]);
                konaklama.GirisTarihi = Convert.ToDateTime(dr2[1]);
                konaklama.CikisTarihi = Convert.ToDateTime(dr2[2]);
                konaklama.KisiSayisi = Convert.ToInt32( dr2[3].ToString());
                konaklama.Fiyat = Convert.ToDecimal(dr2[4]);
                konaklamas.Add(konaklama);
            }
            dr2.Close();
            bgl.baglanti().Close();
            return konaklamas;
        }

        public void Insert(Konaklama entity)
        {
            SqlCommand kmt = new SqlCommand("insert into Ulasim (KisiSayisi,GirisTarihi,CikisTarihi,Fiyat,TelNo) Values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", entity.KisiSayisi);
            kmt.Parameters.AddWithValue("@p2", entity.GirisTarihi);
            kmt.Parameters.AddWithValue("@p3", entity.CikisTarihi);
            kmt.Parameters.AddWithValue("@p4", entity.Fiyat);
            kmt.Parameters.AddWithValue("@p5", entity.TelNo);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public void Remove(Konaklama entity)
        {
            SqlCommand kmt = new SqlCommand("delete from Konaklama Where KonaklamaId=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", entity.KonaklamaId);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public void Update(Konaklama entity)
        {
            SqlCommand kmt = new SqlCommand("update Konaklama Set  KisiSayisi=@p1,GirisTarihi=@p2,CikisTarihi=@p3,Fiyat=@p4", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", entity.KisiSayisi);
            kmt.Parameters.AddWithValue("@p2", entity.GirisTarihi);
            kmt.Parameters.AddWithValue("@p3", entity.CikisTarihi);
            kmt.Parameters.AddWithValue("@p4", entity.Fiyat);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
