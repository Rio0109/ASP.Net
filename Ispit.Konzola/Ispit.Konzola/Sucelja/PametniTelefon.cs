using Ispit.Konzola.Sucelja;
using System;

namespace Sucelja
{
    public class PametniTelefon : IPametniTelefon
    {
        public string Model { get; private set; }

        public PametniTelefon(string model)
        {
            Model = model;
        }

        public string Poziv(string telefonski_broj)
        {
            if (ProvjeriAkoJeValidanBroj(telefonski_broj))
            {
                return $"Evo Zovem {telefonski_broj}.";
            }
            else
            {
                return "Neispravan telefonski broj!";
            }
        }

        public string Surfanje(string url)
        {
            if (ProvjeriAkoJeValidanUrl(url))
            {
                return $"Surfam na: {url}.";
            }
            else
            {
                return "Neispravan URL!";
            }
        }

        public bool ProvjeriAkoJeValidanUrl(string url)
        {
            foreach (char c in url)
            {
                if (char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool ProvjeriAkoJeValidanBroj(string telefonski_broj)
        {
            foreach (char c in telefonski_broj)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
