using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Class
    {
        public string[] Wczytaj_dane()
        {
            string[] dane = File.ReadAllLines("dane.txt");
            return dane;
        }

        public void Show_dane(sting[] dane)
        {
            Console.WriteLine("Cyfra i odpowiadający jej słowo:");
            for (int i = 0; i < dane.Length; i++)
            {
                Console.WriteLine(i + " - " + dane[i]);
            }
        }

        public void Mnemonika()
        {

        }
    }
}
