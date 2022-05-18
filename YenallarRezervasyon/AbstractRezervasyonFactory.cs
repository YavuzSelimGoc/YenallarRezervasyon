using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YenallarRezervasyon
{
    public abstract class AbstractRezervasyonFactory
    {
        public abstract IUlasim UlasimOlustur(Ulasim u);
        public abstract IKonaklama KonaklamaOlustur(Konaklama k);
    }
}
