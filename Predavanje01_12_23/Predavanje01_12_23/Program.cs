#region Primjer1
string ime = "Ivan";
string prezime = "Ristovski";
string adresa = "Krlezina ";
string kucnibroj = "18";
string punoIme = ime + "" + prezime + "" + adresa + "" + kucnibroj;
string zarezrazmak = punoIme.Replace();
Console.WriteLine(punoIme);

#endregion
//  ivan@algebra.hr

#region Primjer 2
string recenica = " Dobar dan";
string rijec = recenica.Substring(6, 3);
Console.WriteLine(rijec);

string poruka = "Dobar dan";
string novaporuka = poruka.Replace(" dan", "večer");
Console.WriteLine(novaporuka);
#endregion

#region Zadatak
string voce = "jabuka";
string novovoce = voce.Replace('a', 'o');
Console.WriteLine(novovoce);
#endregion
