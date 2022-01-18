using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsAppBiblioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Osoba os = new Osoba(inputName.Text, inputSurname.Text, Int32.Parse(inputAge.Text));
            outputInfo.Text = $"Dodano uzytkownika {os.ToString()}";
            listOsoby.Items.Add(os);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void addBook_Click(object sender, EventArgs e)
        {
            Ksiazka ks = new Ksiazka(inputTytul.Text, Int32.Parse(inputDataWydania.Text), (Osoba)listOsoby.SelectedItems[0]);
            outputInfo.Text = $"Dodano ksiazke {ks.ToString()}";
            spisKsiazek.Items.Add(ks);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selectedAuthor = listOsoby.SelectedItem.ToString();
            //selectedAuthor = listOsoby.SelectedIndex.ToString();
            //outputInfo.Text = $"Wybrano {selectedAuthor}";
        }

        private void loadDefaultData_Click(object sender, EventArgs e)
        {
            //dodac sprawdzenie czy to juz jest w tablicy co chce zaladowac
            Osoba os1 = new Osoba("Adam", "Mickiewicz", 36);
            Osoba os2 = new Osoba("Henryk", "Sienkiewicz", 43);
            listOsoby.Items.Add(os1);
            listOsoby.Items.Add(os2);

            Ksiazka k1 = new Ksiazka("Pan Tadeusz", 2021, os1);
            Ksiazka k2 = new Ksiazka("Potop", 2019, os2);
            Ksiazka k3 = new Ksiazka("Quo Vadis", 2017, os2);
            Ksiazka k4 = new Ksiazka("W pustyni i w puszczy", 2018, os2);
            spisKsiazek.Items.Add(k1);
            spisKsiazek.Items.Add(k2);
            spisKsiazek.Items.Add(k3);
            spisKsiazek.Items.Add(k4);

            Czytelnik cz1 = new Czytelnik("Bob", "Bobson", 39);
            Czytelnik cz2 = new Czytelnik("Ben", "Benson", 25);
            listCzytelnicy.Items.Add(cz1);
            listCzytelnicy.Items.Add(cz2);

            cz1.DodajKsiaze(k1);
            cz1.DodajKsiaze(k2);

            cz2.DodajKsiaze(k2);
            cz2.DodajKsiaze(k3);
            cz2.DodajKsiaze(k4);

            Recenzent r1 = new Recenzent("Jan", "Kowalski", 33);
            Recenzent r2 = new Recenzent("Maciej", "Konieczny", 28);
            listRecenzenci.Items.Add(r1);
            listRecenzenci.Items.Add(r2);

            r1.DodajKsiaze(k1);
            r1.DodajKsiaze(k2);
            r1.DodajKsiaze(k3);

            r2.DodajKsiaze(k2);
            r2.DodajKsiaze(k3);
            r2.DodajKsiaze(k4);
        }

        private void spisOsob_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Czytelnik czyt = new Czytelnik((Osoba)listOsoby.SelectedItems[0]);
            outputInfo.Text = $"Dodano czytelnika {czyt.ToString()} poprzez wybor osoby";
            listCzytelnicy.Items.Add(czyt);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void addCzytelnikByName_Click(object sender, EventArgs e)
        {
            Czytelnik czyt = new Czytelnik(inputName.Text, inputSurname.Text, Int32.Parse(inputAge.Text));
            outputInfo.Text = $"Dodano czytelnika {czyt.ToString()} podajac imie, nazwisko i wiek";
            listCzytelnicy.Items.Add(czyt);
        }

        private void showReadBooks_Click(object sender, EventArgs e)
        {
            Czytelnik czyt = (Czytelnik)listCzytelnicy.SelectedItems[0];
            outputInfo.Text = $"{czyt.ToString()} przeczytal: \n{czyt.GetKsiazki()}";
        }

        private void addRecenzent_Click(object sender, EventArgs e)
        {
            Recenzent rec = new Recenzent(inputName.Text, inputSurname.Text, Int32.Parse(inputAge.Text));
            outputInfo.Text = $"Dodano recenzenta {rec.ToString()}";
            listRecenzenci.Items.Add(rec);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Recenzent rec = (Recenzent)listRecenzenci.SelectedItems[0];
            outputInfo.Text = $"{rec.ToString()} ocenil: \n{rec.GetBooksGrade()}";
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            outputInfo.Text = "Dokonano serializacji:\n";
            BinaryFormatter binFormater = new BinaryFormatter();
            using (Stream fs = new FileStream("bibliotekaSave - Osoby.dat", FileMode.Create, FileAccess.Write))
            {
                for (int i = 0; i < listOsoby.Items.Count; i++)
                {
                    Osoba o = (Osoba)listOsoby.Items[i];
                    binFormater.Serialize(fs, o);
                    outputInfo.Text += o.ToString() + "\n";
                }
            }

            using (Stream fs = new FileStream("bibliotekaSave - Ksiazki.dat", FileMode.Create, FileAccess.Write))
            {
                for (int i = 0; i < spisKsiazek.Items.Count; i++)
                {
                    Ksiazka k = (Ksiazka)spisKsiazek.Items[i];
                    binFormater.Serialize(fs, k);
                    outputInfo.Text += k.ToString() + "\n";
                }
            }

            using (Stream fs = new FileStream("bibliotekaSave - Czytelnicy.dat", FileMode.Create, FileAccess.Write))
            {
                for (int i = 0; i < listCzytelnicy.Items.Count; i++)
                {
                    Czytelnik c = (Czytelnik)listCzytelnicy.Items[i];
                    binFormater.Serialize(fs, c);
                    outputInfo.Text += c.ToString() + "\n";
                }
            }

            using (Stream fs = new FileStream("bibliotekaSave - Recenzenci.dat", FileMode.Create, FileAccess.Write))
            {
                for (int i = 0; i < listRecenzenci.Items.Count; i++)
                {
                    Recenzent r = (Recenzent)listRecenzenci.Items[i];
                    binFormater.Serialize(fs, r);
                    outputInfo.Text += r.ToString() + "\n";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            outputInfo.Text = "Deserialize:\n";

            using (Stream fsr = new FileStream("bibliotekaSave - Osoby.dat", FileMode.Open, FileAccess.Read))
            {
                //Osoba o = (Osoba)binFormater.Deserialize(fsr);
                //listOsoby.Items.Add(o);
                //outputInfo.Text += o.ToString() + "\n";
                //foreach(Osoba o in (Osoba)binFormater.Deserialize(fsr))

                //listOsoby = (Osoba)binFormater.Deserialize(fsr);
                /*spisKsiazek = (Ksiazka)binFormater.Deserialize(fsr);
                listCzytelnicy = (Czytelnik)binFormater.Deserialize(fsr);
                listRecenzenci = (Recenzent)binFormater.Deserialize(fsr);*/
            }
        }
    }
}
