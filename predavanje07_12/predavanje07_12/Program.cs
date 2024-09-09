
Console.WriteLine("Koliko zelis unjeti brojeva");
int unioKorisnik = int.Parse(Console.ReadLine());
List<int> brojevii = new List<int>();

for (int i = 0; i < unioKorisnik; i++)
{
    Console.WriteLine($"Unesi {i + 1}. broj:");
    int unesi = int.Parse(Console.ReadLine());
    brojevii.Add(unesi);
}
Console.WriteLine("Parni obrnuto:");

for (int i = brojevii.Count - 1; i >= 0; i--)
{
    if (brojevii[i] % 2 == 0)
}
{
    Console.WriteLine($"{brojevii[i]} ");
}
