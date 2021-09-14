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
            List<int> rajtszamok = new List<int>();
            List<int> dupla = new List<int>();
            //foreach (var l  in lista)
            //{
            //    if (!rajtszamok.Contains(l.Rajtszam) && l.Rajtszam!=0)
            //    {
            //        rajtszamok.Add(l.Rajtszam);
            //    }
            //}
            //foreach (var l in lista)
            //{
            //    if (rajtszamok.Contains(l.Rajtszam) && l.Rajtszam != 0)
            //    {
            //        dupla.Add(l.Rajtszam);
            //    }
            //}
            for (int i = 0; i < lista.Count; i++)
            {
                int szamlalo = 0;
                foreach (var l in lista)
                {
                    if (lista[i].Rajtszam==l.Rajtszam && l.Rajtszam!=0 && !dupla.Contains(lista[i].Rajtszam))
                    {
                        dupla.Add(lista[i].Rajtszam);
                    }
                }
                //if (szamlalo!=0)
                //{
                //    dupla.Add(lista[i].Rajtszam);
                //}
            }
            for (int i = 0; i < dupla.Count; i++)
            {
                Console.Write(dupla[i] + " ");
            }
        }

        private static void HatodikFeladat()
        {
            int legkisebb = lista[0].Rajtszam;
            string nemzetiseg="";
            foreach (var l in lista)
            {
                if (l.Rajtszam!=0 && l.Rajtszam<legkisebb)
                {
                    legkisebb = l.Rajtszam;
                    nemzetiseg = l.Nemzetiseg;
                }
            }
            Console.WriteLine($"6.feladat: {nemzetiseg}");
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
