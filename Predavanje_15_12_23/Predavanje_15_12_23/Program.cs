
using Predavanje_15_12_23.Model;

#region Primjer2
Polaznik polaznik = new Polaznik();
Console.WriteLine("Upisi ime polaznika: ");
polaznik.Ime = Console.ReadLine();

Console.WriteLine("Upisi prezime polaznika: ");
polaznik.Prezime = Console.ReadLine();


Console.WriteLine($"Polazniku je ime {polaznik.Ime} {polaznik.Prezime}");




#endregion