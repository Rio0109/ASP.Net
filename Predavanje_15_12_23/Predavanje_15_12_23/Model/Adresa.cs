using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_15_12_23.Model
{
    internal class Adresa
    {

        public string Ulica { get; set; }
        public string KucniBroj { get; set; }
        public string Grad { get; set; }
        public int PP { get; set; }
        public TipAdrese TipAdrese { get; set; }

    }

    public enum TipAdrese
    {
        Prebivaliste,
        Boraviste,
        PoslovnaAdresa
    }
}
