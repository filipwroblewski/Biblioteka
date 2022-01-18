using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppBiblioteka
{
    [Serializable]
    class Czytelnik : Osoba
    {
        protected List<Ksiazka> przeczytaneKsiazski;

        public Czytelnik(string name, string surname, int age) : base(name, surname, age)
        {
            przeczytaneKsiazski = new List<Ksiazka>();
        }

        public Czytelnik(Osoba os) : base(os.Imie, os.Nazwisko, os.Wiek)
        {
            przeczytaneKsiazski = new List<Ksiazka>();
        }

        public void DodajKsiaze(Ksiazka book)
        {
            this.przeczytaneKsiazski.Add(book);
        }

        public List<Ksiazka> PrzeczytaneKsiazski { get => przeczytaneKsiazski; }

        /*public string WypiszKsiazki()
        {
            string info = "";
            foreach (Ksiazka book in this.przeczytaneKsiazski)
            {
                info+=$"{book.Autor.Imie} {book.Autor.Nazwisko} \"{book.Tytul}\"\n";
            }
            return info;
        }*/

        public string GetKsiazki()
        {
            string books = "";
            foreach (Ksiazka book in this.przeczytaneKsiazski)
            {
                books += (book + "\n");
            }
            return books;
        }

        public override void Wypisz()
        {
            Console.Write("Przeczytane ksiazki przez: ");
            base.Wypisz();
            Console.Write(this.GetKsiazki());
        }

    }
}
