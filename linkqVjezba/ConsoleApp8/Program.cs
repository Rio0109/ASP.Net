using ConsoleApp8.Model;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polaznik[] ListaPolaznika =
            {
                new Polaznik() { id = 1, Ime="Petar", Starost = 22},
                new Polaznik() { id = 2, Ime="Ivo", Starost = 18},
                new Polaznik() { id = 3, Ime="Simun", Starost = 25},
                new Polaznik() { id = 4, Ime="Neso", Starost = 40},
                new Polaznik() { id = 5, Ime="Alex", Starost = 23},
                new Polaznik() { id = 6, Ime="Robert", Starost = 24},
                new Polaznik() { id = 7, Ime="Panco", Starost = 60},
            };
            Console.WriteLine("************************************");
            Console.WriteLine("Primjer Koristenja Linq THENBY operatora");
            Console.WriteLine("************************************");

            var sortiraj_visestruko_ulazne = ListaPolaznika.OrderBy(y=> y.Ime).ThenBy(y=>y.Starost);



        }
    }
}
