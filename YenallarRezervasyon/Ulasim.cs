using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YenallarRezervasyon
{
    public class Ulasim
    {
        public int UlasimId { get; set; }
        public DateTime GidisTarih { get; set; }
        public DateTime DonusTarih { get; set; }
        public decimal Fiyat { get; set; }
        public string FirmaAdi { get; set; }

        public string UlasimTuru { get; set; }
        public int MusteriID { get; set; }
        public string TelNo { get; set; }
        public virtual Musteri musteri { get; set; }


    }
}
