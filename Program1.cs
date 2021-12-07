using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polugodišnja_provjera_znanja
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int max;
            do
            {
                Console.WriteLine("Unesi 3 dvoznamenkasta broja:(ako nisu svi dvoznamenkasti trazit ce se ponovan unos sva 3 broja) ");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
            }
            while (a < 10 || a > 99 || b < 10 || b > 99 || c < 10 || c > 99);
           
            if(a>=b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            Console.WriteLine("Najveci broj je: " +max);
            Console.ReadLine();
        }
    }
}
