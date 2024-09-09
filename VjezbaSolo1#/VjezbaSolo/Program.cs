#region Zadatka1
//Console.WriteLine("Unesi svoju godinu rodjenja");
//int godinaRodjenja = int.Parse(Console.ReadLine());
//int trenutnaGodina = DateTime.Now.Year;
//bool jePunoljetan = false;
//int imaGodina = trenutnaGodina - godinaRodjenja;
//jePunoljetan = imaGodina >= 18;

//int godinaRodjenja = int.Parse(Console.ReadLine());
//int trenutnaGodina = DateTime.Now.Year;
//bool jePunoljetan = trenutnaGodina - godinaRodjenja >= 18;
//if (jePunoljetan)
//{
//    Console.WriteLine("Korisnik je punoljetan.");
//}
//else
//{
//    Console.WriteLine("Korisnik nije punoljetan.");
//}
#endregion
#region Zadatak2
//Console.WriteLine("Da li user ima admin prava? (da/ne)");
//string odgovor = Console.ReadLine();

//// bool jeAdmin = (odgovor == "da"); 
//bool jeAdmin = odgovor.ToLower() == "da"; // .ToLower sluzi za case insensitive da nije bitno veliko ili malo slovo

//Console.WriteLine(odgovor =="da"); // vraca true
//Console.WriteLine(odgovor !="da"); // vraca false

//if (jeAdmin)
//{
//    Console.WriteLine("Pristup odobren.");
//}
//else
//{
//    Console.WriteLine("Pristup odbijen.");
//}


#endregion
#region Zadatak3
using System.ComponentModel.Design;
// Boolean vjezbe 
string odgovorDa = "da";

Console.WriteLine("Da li ste clan kluba? (da/ne)");
bool jeClan = Console.ReadLine().ToLower() == odgovorDa;

Console.WriteLine("Da li imate popust? (da/ne)");
bool imaPopust = Console.ReadLine().ToLower() == odgovorDa;

if (jeClan && imaPopust)
{
    Console.WriteLine("Imate 20% popusta na sve");
}
else if (jeClan)
    Console.WriteLine("Imate 10% popusta");
else
    Console.WriteLine("Nemate popust te razmislite o učlanjivanju");


#endregion
#region Zadatak4

#endregion