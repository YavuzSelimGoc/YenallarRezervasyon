using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YenallarRezervasyon
{
    public class Fact_Ucak_Cadir : AbstractRezervasyonFactory
    {
        public override IKonaklama KonaklamaOlustur(Konaklama konaklama)
        {
            return new Cadir();
        }

        public override IUlasim UlasimOlustur(Ulasim ulasim)
        {
            return new Ucak();
        }
    }
}
