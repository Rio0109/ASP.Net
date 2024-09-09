namespace Ispit.Model

#region Ispit
{
    public class Ucenik
    {

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public DateTime DatumRodjenja { get; set; }

        public double Prosjek { get; set; }



        public int Starost(DateTime datumRodjenja)
        {
            int starost = DateTime.Now.Year - datumRodjenja.Year;

            return starost;
        }


        public void IspisProsjeka(double prosjekKorisnika)
        {

            if (prosjekKorisnika >= 1 && prosjekKorisnika <= 1.49)
            {
                Console.WriteLine("Nedovoljan");
            }
            else if (prosjekKorisnika >= 1.50 && prosjekKorisnika <= 2.49)
            {
                Console.WriteLine("Dovoljan");
            }
            else if (prosjekKorisnika >= 2.5 && prosjekKorisnika <= 3.49)
            {
                Console.WriteLine("Dobar");
            }
            else if (prosjekKorisnika >= 3.5 && prosjekKorisnika <= 4.49)
            {
                Console.WriteLine("Vrlo dobar");
            }
            else if (prosjekKorisnika >= 4.5 && prosjekKorisnika <= 5)
            {
                Console.WriteLine("Odlican");
            }
            else
            {
                Console.WriteLine("Neispravan unos prosjeka!");

            }

        }

        public Ucenik UnesiUcenika()
        {
            Console.WriteLine("Unesi ime ucenika");

            string ImeUcenik = Console.ReadLine();

            Console.WriteLine("Unesi prezime ucenika");

            string PrezimeUcenik = Console.ReadLine();

            Console.WriteLine("Unesi datum rodjena ucenika");

            DateTime datumRodjenja = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Unesi prosjek ucenika");

            double prosjek = double.Parse(Console.ReadLine());

            return new Ucenik
            {
                Ime = ImeUcenik,
                Prezime = PrezimeUcenik,
                DatumRodjenja = datumRodjenja,
                Prosjek = prosjek
            };

        }

    }

}
#endregion

//  Ivan Ristovski