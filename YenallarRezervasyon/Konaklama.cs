using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YenallarRezervasyon
{
    public class Konaklama
    {
        public int KonaklamaId { get; set; }
        public int KisiSayisi { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal Fiyat { get; set; }
        public string TelNo { get; set; }

        public int MusteriID { get; set; }
    }
}
