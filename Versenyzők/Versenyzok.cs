using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versenyzők
{
    class Versenyzok
    {
        private string nev;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }
        private string szuletesi_datum;

        public string Szuletesi_Datum
        {
            get { return szuletesi_datum; }
            set { szuletesi_datum = value; }
        }

        private string nemzetiseg;

        public string Nemzetiseg
        {
            get { return nemzetiseg; }
            set { nemzetiseg = value; }
        }

        private int rajtszam;

        public int Rajtszam
        {
            get { return rajtszam; }
            set { rajtszam = value; }
        }

        public Versenyzok(string nev, string szuletesi_datum, string nemzetiseg, int rajtszam)
        {
            this.nev = nev;
            this.szuletesi_datum = szuletesi_datum;
            this.nemzetiseg = nemzetiseg;
            this.rajtszam = rajtszam;
        }
    }
}
