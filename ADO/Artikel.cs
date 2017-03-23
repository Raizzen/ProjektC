using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    class Artikel
    {
        public int ArtikelOid { get; set; }
        public int ArtikelNr { get; set; }
        public int ArtikelGruppe { get; set; }
        public String Bezeichnung { get; set; }
        public Int16 Bestand { get; set; }
        public Int16 Meldebestand { get; set; }
        public int Verpackung { get; set; }
        public decimal VkPreis { get; set; }
        public DateTime letzteEntnahme { get; set; }
    }
}
