using System;
using Ispit.Konzola.Sucelja;
using Sucelja;

class Program
{
    static void Main(string[] args)
    {
        PametniTelefon telefon = new PametniTelefon(" model");

        TestirajTelefon(telefon);
    }

    static void TestirajTelefon(IPametniTelefon telefon)
    {
        Console.WriteLine("Koji broj da zovem?");
        string broj = Console.ReadLine();

        Console.WriteLine("Koju web stranicu da posjetim:");
        string url = Console.ReadLine();

     
        string rezultatPoziva = telefon.Poziv(broj);
        string rezultatSurfanja = telefon.Surfanje(url);

        Console.WriteLine(rezultatPoziva);
        Console.WriteLine(rezultatSurfanja);
    }
}
