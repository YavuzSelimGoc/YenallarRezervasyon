using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YenallarRezervasyon
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        public string AdiSoyadi { get; set; }
        public string TcKimlikNo { get; set; }
        public string TelefonNo { get; set; }
        public string Mail { get; set; }

        public Konaklama Konaklama { get; set; }
        public Ulasim Ulasim { get; set; }
        public Musteri()
        {
            this.Konaklama = new Konaklama();
            this.Ulasim = new Ulasim();
        }

    }
}
