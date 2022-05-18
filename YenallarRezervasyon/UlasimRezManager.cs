using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace YenallarRezervasyon
{
    public class UlasimRezManager:IUlasimService
    {
        SqlBaglanti bgl = new SqlBaglanti();
        private AbstractRezervasyonFactory _abstractRezervasyonFactory;
        private IUlasim _ulasim;
        Ulasim u = new Ulasim();
        
        
        public UlasimRezManager(AbstractRezervasyonFactory abstractRezervasyonFactory)
        {
            _abstractRezervasyonFactory = abstractRezervasyonFactory;
            _ulasim = abstractRezervasyonFactory.UlasimOlustur(u);
        }

        public void Create(Ulasim entity)
        {
            throw new NotImplementedException();
        }

        public Ulasim GetById(int id)
        {
            Ulasim ulasim = new Ulasim();
            SqlCommand kmt = new SqlCommand("select*from Ulasim where UlasimID=@p1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1",id);
            SqlDataReader dr2 = kmt.ExecuteReader();
            while (dr2.Read())
            {
                ulasim.UlasimId = Convert.ToInt32(dr2[0]);
                ulasim.GidisTarih = Convert.ToDateTime(dr2[1]);
                ulasim.DonusTarih = Convert.ToDateTime(dr2[2]);
                ulasim.FirmaAdi = dr2[3].ToString();
                ulasim.Fiyat = Convert.ToDecimal(dr2[4]);
            }
            dr2.Close();
            bgl.baglanti().Close();
            return ulasim;
        }

        public  DataTable GetListAll()
        {
            SqlBaglanti bgl = new SqlBaglanti();
            //dataGridView1.DataSource = rezervasyon.GetListAll();
            SqlCommand kmt = new SqlCommand("execute GetAllRezervasyons", bgl.baglanti());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(kmt);
            da.Fill(dt);
      

            bgl.baglanti().Close();

            return dt;
        }

        public void Insert(Ulasim entity)
        {
            
            SqlCommand kmt = new SqlCommand("insert into Ulasim (GidisTarih,DonusTarih,FirmaAdi,Fiyat,MusteriID,UlasimTuru,TelNo) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1",entity.GidisTarih);
            kmt.Parameters.AddWithValue("@p2",entity.DonusTarih);
            kmt.Parameters.AddWithValue("@p3",entity.FirmaAdi);
            kmt.Parameters.AddWithValue("@p4",entity.Fiyat);
            kmt.Parameters.AddWithValue("@p5", entity.MusteriID.ToString()) ;
            kmt.Parameters.AddWithValue("@p6", entity.UlasimTuru);
            kmt.Parameters.AddWithValue("@p7", entity.TelNo);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public void Remove(Ulasim entity)
        {
            SqlCommand kmt = new SqlCommand("delete from Ulasim Where UlasimId=@p1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1",entity.UlasimId);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public void Update(Ulasim entity)
        {
            SqlCommand kmt = new SqlCommand("update Ulasim Set GidisTarih=@p1,DonusTarih=@p2,FirmaAdi=@p3,Fiyat=@p4  where UlasimID=@p5", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1",entity.GidisTarih);
            kmt.Parameters.AddWithValue("@p2",entity.DonusTarih);
            kmt.Parameters.AddWithValue("@p3",entity.FirmaAdi);
            kmt.Parameters.AddWithValue("@p4",entity.Fiyat);
            kmt.Parameters.AddWithValue("@p5",entity.UlasimId);
          
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        List<Ulasim> IGenericRepository<Ulasim>.GetListAll()
        {
            throw new NotImplementedException();
        }
    }
}
