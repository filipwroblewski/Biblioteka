using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppBiblioteka
{
    [Serializable]
    class Ksiazka
    {
        public Ksiazka(string tytul, int dataWydania, Osoba autor)
        {
            this.Tytul = tytul;
            this.DataWydania = dataWydania;
            this.Autor = autor;
        }

        public string Tytul { get; }
        public int DataWydania { get; }
        public Osoba Autor { get; }

        public void Wypisz()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"{this.Autor.Imie} {this.Autor.Nazwisko} \"{this.Tytul}\" ({this.DataWydania})";
        }
    }
}
