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
            Console.WriteLine("5.feladat:");
            foreach (var l in lista)
            {
                string[] atmeneti = l.Szuletesi_Datum.Split('.');
                if (Convert.ToInt32(atmeneti[0])<=1900)
                {
                    Console.WriteLine($"\t{l.Nev} ({atmeneti[0]}. {atmeneti[1]}. {atmeneti[2]}.)");
                }
            }
        }

        private static void NegyedikFeladat()
        {
            Console.WriteLine($"4.feladat: {lista[lista.Count-1].Nev}");
        }

        private static void HarmadikFeladat()
        {
            Console.WriteLine($"3.feladat: {lista.Count}");
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
