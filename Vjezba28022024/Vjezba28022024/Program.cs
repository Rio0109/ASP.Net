using System.Threading.Channels;
using Vjezba28022024.Model;

namespace Vjezba28022024
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Polaznik polaznik = new Polaznik
            {
                Ime = "Polaznik Ime",
                Prezime = "Polaznik prezime",
                    OIB = "123456789"

            };
            Predavac predavac = new Predavac 
            {
                Ime = "Predavac Ime",
                Prezime = "Predavac prezime",
                OIB = "133456789"

            };
            zaposlenik zaposlenik = new zaposlenik
            {
                Ime = "Zaposlenik Ime",
                Prezime = "Zaposlenik prezime",
                OIB = "123456749"

            };
            IspisOsobe(polaznik);
            IspisOsobe(predavac);
            IspisOsobe(zaposlenik);

            
            IspisZaposlenika(predavac);
            IspisZaposlenika(zaposlenik);

        }
        static void IspisZaposlenika(IZaposlenik zaposlenik)
        {
            zaposlenik.IspisiOdjel();
            zaposlenik.IspisiVoditelja();
        }




        static void IspisOsobe(IQsoba qsoba)
        {
            Console.WriteLine($"Osoba je imena {qsoba.Ime}{qsoba.Prezime} i oib: {qsoba.OIB}");
                }
    }
}
