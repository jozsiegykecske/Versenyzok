using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Versenyzők
{
    class Program
    {
        static List<Versenyzok> lista = new List<Versenyzok>();
        static void Main(string[] args)
        {
            MasodikFeladat();
            HarmadikFeladat();
            NegyedikFeladat();
            OtodikFeladat();
            HatodikFeladat();
            HetedikFeladat();
            Console.ReadKey();
        }

        private static void HetedikFeladat()
        {
            
        }

        private static void HatodikFeladat()
        {
            
        }

        private static void OtodikFeladat()
        {
            
        }

        private static void NegyedikFeladat()
        {
            
        }

        private static void HarmadikFeladat()
        {
            
        }

        private static void MasodikFeladat()
        {
            StreamReader be = new StreamReader("pilotak.csv");
            be.ReadLine();
            while (!be.EndOfStream)
            {
                string[] atmeneti = be.ReadLine().Split(';');
                int rajtszam=0;
                if (!string.IsNullOrEmpty(atmeneti[3]))
                {
                    rajtszam = Convert.ToInt32(atmeneti[3]);
                }
                lista.Add(new Versenyzok(atmeneti[0],atmeneti[1],atmeneti[2], rajtszam));
            }
            be.Close();
        }
    }
}
