using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            Metody obiekt = new Metody();
            
            string[] dane = obiekt.Wczytaj_dane();  //Wczytanie słów z pliku.
            obiekt.Show_dane(dane);                 //Wyświtlenie słów i odpowiadające im cyfry.
         
            string numer_telefonu = "660928380";    //Podany numer telefonu
                     
            obiekt.Mnemonika(numer_telefonu, dane); //Poddanie numeru metodzie mnemotechniki 

            Console.ReadKey();
        }
    }
}
