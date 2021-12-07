using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 Definirajte klasu Stablo sa sljedećim članicama:
a. varijabla tipa bool otpadajuListovi
b. varijabla tipa string vrstaStabla
c. svojstvo OtpadajuListovi (get() i set())
d. konstruktor Stablo(bool) koji će dodijeliti vrijednost proslijeđenog argumenta
varijabli otpadajuListovi
e. override metode ToString()
Definirajte objekt stablo1 tipa Stablo pomoću konstruktora te proslijedite vrijednost
false. Definirajte objekt stablo2 tipa Stablo pomoću konstruktora te proslijedite
vrijednost true.
Ispišite podatke o objektima koristeći ToString() metodu, na način da ukoliko je
vrijednost varijable otpadajuListovi true, vrijednost varijable vrstaStabla je
bijelogorično, a ukoliko je vrijednost varijable otpadajuListovi false, vrijednost
varijable vrstaStabla je crnogorično.
 */
namespace Polugodisnja_Provjera_Znanja2
{
    class Stablo
    {
        public bool otpadajuListovi;
        public String vrstaStabla;

        public bool OtpadajuListovi
        {
            get { return otpadajuListovi; }
            set
            {
                OtpadajuListovi = otpadajuListovi;
            }
        }
        public Stablo(bool aotpadajuListovi)
        {
            otpadajuListovi = aotpadajuListovi;
        }
        public string VrstaStabla
        {
            get { if (OtpadajuListovi == true)
                {
                    vrstaStabla = "bijelogoricno";
                    return vrstaStabla;
                }
                else
                    vrstaStabla = "crnogoricno";
                return vrstaStabla;
            }
            }
        public override string ToString()
        {
            string ispis = "Vrsta stabla: " + VrstaStabla + "\n"
                         + "OtpadajuListovi: " + OtpadajuListovi;
            return ispis;
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(false);
            Stablo stablo2 = new Stablo(true);

           
            Console.WriteLine(stablo1.ToString());
            Console.ReadLine();
        }
        

    }
}

