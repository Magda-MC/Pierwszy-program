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

if (wiek <= 18 && plec == true)
{
        Console.WriteLine("Niepełnoletni mężczyzna"); 

}
else   
if (imie == "Ewa" && wiek == 33 && plec == false)
{
    Console.WriteLine(imie + ", lat " + wiek);
}

else
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
