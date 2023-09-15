using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2_3
{
    internal class Program
    {
        class Vozilo
        {
            bool JeLiLeti, JeLiPlovi;

            public bool JeLiLeti1 { get => JeLiLeti; set => JeLiLeti = value; }
            public bool JeLiPlovi1 { get => JeLiPlovi; set => JeLiPlovi = value; }

            public Vozilo() { 
           
            }
            string kudaVozi()
            {
                string ispis = ("JeLiLeti" + this.JeLiLeti + "JeLiPLovi" + this.JeLiPlovi);
                return ispis;
            }
        }
        class Brod : Vozilo
        {
            public Brod() {
                JeLiPlovi1 = true;
            }
        }
        class Zrakoplov : Vozilo
        {
            public Zrakoplov() {
                JeLiLeti1 = true;
            }
        }
        static void Main(string[] args)
        /* Definirajte klasu Vozilo sa sljedećim članicama:
• svojstva
JeLiLeti
JeLiPlovi
• metoda
KudaVozi() koja će ispisati vrijednost dviju varijabli članica

Definirajte klase Brod i Zrakoplov izvedene iz klase Vozilo, te im definirajte konstruktore u
kojima ćete varijablama JeLiLeti i JeLiPlovi dodijeliti odgovarajuću vrijednost.
Definirajte dva objekta tipa Brod i Zrakoplov, te ispišite vrijednosti varijabli JeLiLeti i
JeLiPlovi.*/

        {
            Brod a = new Brod();
            Zrakoplov b = new Zrakoplov();

            Console.WriteLine(b.JeLiLeti1);
            Console.WriteLine(a.JeLiPlovi1);
            Console.ReadKey();  
        }
    }
}
