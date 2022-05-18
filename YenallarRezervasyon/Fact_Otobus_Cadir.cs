using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YenallarRezervasyon
{
    public class Fact_Otobus_Cadir : AbstractRezervasyonFactory
    {
        public override IKonaklama KonaklamaOlustur(Konaklama k)
        {
            return new Cadir();
        }

        public override IUlasim UlasimOlustur(Ulasim u)
        {
            return new Otobus();
        }
    }
}
