using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Definirajte klasu KlasaX sa sljedećim članicama:
a. niz tipa int veličine 100 elemenata arr
b. indeks koji će vraćati i postavljati vrijednost svakog pojedinog člana niza arr.
Definirajte objekt x tipa KlasaX, te koristeći indekse dodijelite nizu arr prvih 100
brojeva i ispišite 50. član niza.
 */
namespace Polugodišnja_provjera_znanja3
{
    class KlasaX
    {
        int[] arr = new int[100];

        public int[] Arr { get => this.arr; set => this.arr = value; }

        public KlasaX(int[] aarr)
        {
            arr[]= aarr[];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            for(int brojac=0;brojac<100;brojac++)
            {
                arr[brojac] = brojac;
            }

           Console.WriteLine(arr [50]);
            
        }
    }
}
