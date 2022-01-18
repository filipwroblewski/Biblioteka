# Biblioteka
## System do zarzadzania uzytkownikami biblioteki

Prosta aplikacja gdzie mozna dodawac nowe osoby i ksiazki (z uwzglednieniem autorow) do biblioteki. Mozna takze dodawac czytelnikow i recenzentow. 

### Klasy
#### Osoba
string imie,
string nazwisko,
int wiek

#### Ksiazka
Osoba autor,
string tytul,
int dataWydania

#### Czytelnik : Osoba
List<Ksiazka> przeczytaneKsiazski
  
#### Recenzent : Czytelnik  
  
![Wyglad aplikacji](/img.png)
