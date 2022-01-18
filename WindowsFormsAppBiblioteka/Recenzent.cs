﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppBiblioteka
{
    [Serializable]
    class Recenzent : Czytelnik
    {
        Random random;

        public Recenzent(string name, string surname, int age) : base(name, surname, age)
        {
            random = new Random();
        }

        public override void Wypisz()
        {
            Console.Write($"Ocenione ksiazki przez:");
            base.Wypisz();
            foreach (Ksiazka book in przeczytaneKsiazski)
            {
                book.Wypisz();
                Console.WriteLine($"Ocena: {random.Next(1, 10)}\n");
            }
            Console.WriteLine("");
        }

        public string GetBooksGrade()
        {
            string books = "";
            foreach (Ksiazka b in PrzeczytaneKsiazski)
            {
                books += (b + $" Ocena: {random.Next(1, 10)}\n");
            }
            return books;
        }

    }
}
