using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppBiblioteka
{
    [Serializable]
    class Osoba
    {
        public Osoba(string imie, string surname, int age)
        {
            this.Imie = imie;
            this.Nazwisko = surname;
            this.Wiek = age;
        }

        public string Imie { get; }
        public string Nazwisko { get; }
        public int Wiek { get; }

        public virtual void Wypisz()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"{this.Imie} {this.Nazwisko} ({this.Wiek})";
        }
    }
}
