using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YenallarRezervasyon
{
    public class Fact_Ucak_Otel : AbstractRezervasyonFactory
    {
        public override IKonaklama KonaklamaOlustur(Konaklama k)
        {
            return new Otel();
        }

        public override IUlasim UlasimOlustur(Ulasim u)
        {
            return new Ucak();
        }
    }
}
