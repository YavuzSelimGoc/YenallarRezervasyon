using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YenallarRezervasyon
{
    public class MusteriManager : IMusteriService
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public void Create(Musteri entity)
        {
            throw new NotImplementedException();
        }

        public Musteri GetById(int id)
        {
            Musteri musteri = new Musteri();
            SqlCommand kmt = new SqlCommand("select*from Musteri where MusteriID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr2 = kmt.ExecuteReader();
            while (dr2.Read())
            {
                musteri.MusteriID = Convert.ToInt32(dr2[0]);
                musteri.AdiSoyadi = dr2[1].ToString();
                musteri.TcKimlikNo = (dr2[2]).ToString();
                musteri.TelefonNo = dr2[3].ToString();
                musteri.Mail = dr2[4].ToString();
            }
            dr2.Close();
            bgl.baglanti().Close();
            return musteri;
        }

        public List<Musteri> GetListAll()
        {
            List<Musteri> musteris = new List<Musteri>();

            SqlCommand kmt = new SqlCommand("select*from Musteri", bgl.baglanti());
            SqlDataReader dr2 = kmt.ExecuteReader();
            while (dr2.Read())
            {
                Musteri musteri = new Musteri();
                musteri.MusteriID = Convert.ToInt32(dr2[0]);
                musteri.AdiSoyadi = dr2[1].ToString();
                musteri.TcKimlikNo = (dr2[2]).ToString();
                musteri.TelefonNo = dr2[3].ToString();
                musteri.Mail = dr2[4].ToString();
                musteris.Add(musteri);
            }
            dr2.Close();
            bgl.baglanti().Close();
            return musteris;
        }

        public void Insert(Musteri entity)
        {
            SqlCommand kmt = new SqlCommand("insert into Musteri (AdiSoyadi,TcKimlikNo,TelefonNo,Mail) Values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", entity.AdiSoyadi);
            kmt.Parameters.AddWithValue("@p2", entity.TcKimlikNo);
            kmt.Parameters.AddWithValue("@p3", entity.TelefonNo);
            kmt.Parameters.AddWithValue("@p4", entity.Mail);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public void Remove(Musteri entity)
        {
            SqlCommand kmt = new SqlCommand("delete from Musteri Where MusteriID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", entity.MusteriID);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public void Update(Musteri entity)
        {
            SqlCommand kmt = new SqlCommand("update Musteri set AdiSoyadi=@p1,TcKimlikNo=@p2,TelefonNo=@p3,Mail=@p4)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", entity.AdiSoyadi);
            kmt.Parameters.AddWithValue("@p2", entity.TcKimlikNo);
            kmt.Parameters.AddWithValue("@p3", entity.TelefonNo);
            kmt.Parameters.AddWithValue("@p4", entity.Mail);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
