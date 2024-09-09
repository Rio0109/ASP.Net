#region Primjer1
//int[] brojevi = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int[] brojevi2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // s ovim [] napisemo broj elemenata koje zelimo u nasoj varijabli
//Console.WriteLine(brojevi[7]);
//// [] znak za  Array- a to je neka lista  uvodna zagrada potrebna
//string[] imena = { "Mate", "Ivana", "Šime" };
//Console.WriteLine(imena[2]);

//List<int> brojeviKaoLista = new List<int> {1,2,3,4,5,6,7,8,9,10 };
//Console.WriteLine(brojeviKaoLista);
//brojeviKaoLista.Add(1);
//brojeviKaoLista.Add(200);

//List<string> gradovi = new List<string> { "Split", "Zagreb", "Rijeka" };
//Console.WriteLine(gradovi[1]);
//Console.WriteLine("Unesi jos neki grad:");
//var uneseniGrad = Console.ReadLine();
//gradovi.Add(uneseniGrad);
//Console.WriteLine(gradovi[3]);


//unutar arraya pozivamo po indeksu (indeks se broji od 0 )

// predavac ispod kod njegov

//Console.WriteLine("Unesi još jedan grad: ");
////korisnik unosi novi grad
//string uneseniGrad = Console.ReadLine();
////Koristimo "Add" da bismo pohranili element u listu
//gradovi.Add(uneseniGrad);
////Ispis elementa liste
//Console.WriteLine($"unio si grad: {gradovi[3]}");
////Pitamo korisnika da odabere grad koji zeli ukliti
//Console.WriteLine("Koji grad iz liste zelis ukloniti:");
//Console.WriteLine($"0) {gradovi[0]} 1) {gradovi[1]} 2) {gradovi[2]} 3) {gradovi[3]}");
////Pokupi od korisnika poziciju grada kojeg brisemo
//int odabir = int.Parse(Console.ReadLine());
////pohrani grad (string) koji brismo u zasebnu varijablu
//string odabraniGrad = gradovi[odabir];
////pozovi funkciju untar liste koja ce ukloniti grad
//gradovi.Remove(odabraniGrad);
////ispisi broj gradova koji se trenutno nalaze u listi
//Console.WriteLine($"Uspješno ste uklonili elemnent iz liste, " +
//    $"te sada lista sadrži {gradovi.Count} gradova");
#endregion

#region Zadatak1
//List<int> brojevi = new List<int> { 1, 2, 3, 5, 7, 9, 11 };
//Console.WriteLine($"0){brojevi[0]} 1){brojevi[1]} 2){brojevi[2]} 3){brojevi[3]} 4){brojevi[4]} 5){brojevi[5]} 6){brojevi[6]}");
//Console.WriteLine("Unesi Parni broj za izbaciti");
//int izbac = int.Parse(Console.ReadLine());
//brojevi.Remove(izbac);
//Console.WriteLine("Lista izgleda:");
//Console.WriteLine($"0){brojevi[0]} 1){brojevi[1]} 2){brojevi[2]} 3){brojevi[3]} 4){brojevi[4]} 5){brojevi[5]} ");

#endregion

#region Primjer2 lotto *
//string dobitnaKombinacija = "";
//Random random = new Random();
//for (int brojcanik = 0; brojcanik < 7; brojcanik++)
//{
//	int randomBroj = random.Next(1, 9);
//	dobitnaKombinacija += randomBroj;
//}



//string unioKorisnik = string.Empty; //""
//int brojPogodjenihBrojeva = 0;
//Console.WriteLine("Unesi 7 znameniki za loto: ");
//unioKorisnik = Console.ReadLine();
//for (int i = 0; i < unioKorisnik.Length; i++)
//{
//	if (unioKorisnik[i] == dobitnaKombinacija[i])
//	{
//		brojPogodjenihBrojeva++;
//	}

//}

//if (brojPogodjenihBrojeva == dobitnaKombinacija.Length)
//{
//	Console.WriteLine("Dobitak!");
//}
//else
//{
//	Console.WriteLine("Kombinacija nije dobitna!");
//}
#endregion