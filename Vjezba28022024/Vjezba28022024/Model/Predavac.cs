using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba28022024.Model
{
    public class Predavac : IQsoba,IZaposlenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string OIB { get; set; }

        public void IspisiOdjel()
        {
            Console.WriteLine("Obrazovanje odraslih");
        }

        public void IspisiVoditelja()
        {
            Console.WriteLine("Stjepan Rados"); ;
        }
    }
}
