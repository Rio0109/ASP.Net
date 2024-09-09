using Ispit.Model;

#region ispit
Ucenik ucenik = new Ucenik();

Console.WriteLine("Molimo unesite tri ucenika, jednog po jednog.");

List<Ucenik> ucenici = new List<Ucenik>();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Molimo unesite ucenika  {i + 1}");

    ucenici.Add(ucenik.UnesiUcenika());
}

foreach (var uc in ucenici)
{
    Console.WriteLine(uc.Ime);

    Console.WriteLine(uc.Prezime);

    uc.IspisProsjeka(uc.Prosjek);

    Console.WriteLine(uc.Starost(uc.DatumRodjenja));
};
#endregion

//  Ivan Ristovski