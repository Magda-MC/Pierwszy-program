//Tworzenie zmiennych bez deklaracji wartości
using System.ComponentModel.Design;

string imie;
int wiek;
bool plec;

//Deklaracja wartości dla zmiennych
wiek = 33;
imie = "Ewa";
plec = false;


//Warunkowe wyświetlenie komunikatów

if (imie == "Ewa" && wiek == 33 && plec == false)
{ Console.WriteLine(imie + ", lat " + wiek); }
else
if (wiek <= 30 && plec == false)
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
else
{ Console.WriteLine("Niepełnoletni mężczyzna"); }

