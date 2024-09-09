// ne imenovat fajlove sa donjom crtom sjebavat ce te u buducnosti _  jer nece ga svak priznat kao char 
namespace Predavanje_15_12_23.Model 
{ }
public class Polaznik
{
    public Polaznik()
    {
    }

    public Polaznik(string ime, string prezime)
    {
        Ime = ime;
        Prezime = prezime;

    }

    public Polaznik(string ime)
    {
        Ime = ime;

    }


    public string Ime { get; set; }
    public string Prezime { get; set; }

    #region PrimjeriKonvencija
    //private readonly string _name;
    //public const string Name = "name";

    //public int DodajNovogPolaznika(string imePolaznika, string prezhimePolaznika)
    //{
    //    //c.C
    //    //prvo malo slovo, umjesto razmaka koristimo prvo pocetno slove slj. rec. veliko
    //    //p.c.
    //    //prvo veliko slovo, umjesto razmaka koristimo prvo pocetno slove slj. rec. veliko

    //}
    #endregion




} 