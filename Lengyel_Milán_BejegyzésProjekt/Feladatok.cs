using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Lengyel_Milán_BejegyzésProjekt
{
    internal class Feladatok
    {
        List<Bejegyzes> bejegyzesek1 = new List<Bejegyzes>();
        List<Bejegyzes> bejegyzesek2 = new List<Bejegyzes>();
        private int likeosztas = 0;

        public Feladatok() 
        {
            Beker();
            Beolvas();
            Modosit();
            Likeosztas();
            Kiir();
            Legnepszerubb();
            Soklike();
        }

        public void Beker()
        {
            Console.WriteLine("Mennyi új bejegyzést szeretne írni? ");
            int bejegyzesszam = int.Parse(Console.ReadLine());
            if (bejegyzesszam > 0)
            {
                for (int i = 0; i < bejegyzesszam; i++)
                {
                    Console.WriteLine("Adja meg a " + i + " sorszámú bejegyzés szerzőjét: ");
                    string szerzo = Console.ReadLine();
                    Console.WriteLine("Adja meg a " + i + " sorszámú bejegyzés tartalmát: ");
                    string tartalom = Console.ReadLine();
                    Bejegyzes b = new Bejegyzes(szerzo, tartalom);
                    bejegyzesek2.Add(b);
                    likeosztas++;
                }
            }
            else
            {
                Console.WriteLine("Hibás szám");
            }
            //Console.WriteLine(bejegyzesek2.Count);
        }

        public void Beolvas()
        {
            StreamReader R = new StreamReader("bejegyzesek.csv");

            while (!R.EndOfStream)
            {
                string[] adatok = R.ReadLine().Split(';');
                string szerzo = adatok[0];
                string tartalom = adatok[1];

                Bejegyzes b = new Bejegyzes(szerzo, tartalom);
                bejegyzesek1.Add(b);
            }
            foreach (var item in bejegyzesek1)
            {
                Console.WriteLine(item);
                //likeosztas++;
            }
        }

        public void Likeosztas()
        {
            int randomszam;
            Random r = new Random();
            for (int i = 0; i < likeosztas*20; i++)
            {
                randomszam = r.Next(0, bejegyzesek2.Count-1);
                bejegyzesek2[randomszam].Like();
            }
        }

        public void Modosit()
        {
            Console.WriteLine("Mire szeretné módosítani a tartalmat?");
            string modositott = Console.ReadLine();
            bejegyzesek1[1].Tartalom = modositott;
        }

        public void Kiir()
        {
            foreach(var item in bejegyzesek2)
            {
                Console.WriteLine(item);
            }
        }

        public void Legnepszerubb()
        {
            int legnagyobb = 0;
            foreach( var item in bejegyzesek2)
            {
                if(item.Likeok > legnagyobb)
                {
                    legnagyobb = item.Likeok;
                }
            }
            Console.WriteLine(legnagyobb);
        }

        public void Soklike()
        {
            int mennyiseg = 0;
            foreach (var item in bejegyzesek2)
            {
                if (item.Likeok > 35)
                {
                    mennyiseg++;
                }
            }
            Console.WriteLine(mennyiseg);
        }
    }
}
