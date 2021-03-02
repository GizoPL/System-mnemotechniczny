using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp34
{
    class Metody
    {
        public string[] Wczytaj_dane()           //Wczytanie zakładek z pliku dane.txt do tablicy dane.
        {
            string[] dane = File.ReadAllLines("dane.txt");
            return dane;
        }

        public void Show_dane(string[] dane)                       //Wyświetlanie zakładek dla poszczególnych cyfr.
        {
            Console.WriteLine("Cyfra i odpowiadające jej słowo:");
            for (int i = 0; i < dane.Length; i++)
            {
                Console.WriteLine(i + " - " + dane[i]);
            }
        }

        public void Mnemonika(string numer_telefonu, string[] dane)                 //Wyświetlanie numeru z postaci numerycznej na postać złożoną z zakładek.
        {
            
            Console.Write("Numer " + numer_telefonu + " możemy zapamiętać jako: ");
            
            int[] tablica = new int[10];                                //Tablica do której bedą przekazywane kolejne cyfry z numeru telfonu na postać int-ów.
            for (int j = 0; j < 9; j++)
            {
                tablica[j] = Convert.ToInt32("" + numer_telefonu[j]);   //Przekazywanie kolejnych cyfr numeru telefonu po konwersji do tablicy.
            }

            for (int i = 0; i < 9; i++)                  //Wyświetlenie zakładek dla poszczególnych cyfr.
            {
                if (i > 0 && i % 3 == 0)                 //W celu wprowadzenia przejrzystości wprowadzamy znak spacji po 3 kolejnych zakładkach.
                {
                    Console.Write(" ");
                }
                Console.Write(dane[tablica[i]]);         //Wyświetlenie zkaładki.
                
            }

            
        }
    }
}