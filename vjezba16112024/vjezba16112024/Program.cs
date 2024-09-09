using Kalkulator;


    kalkuliraj kalkuliraj = new kalkuliraj();

{
    static void Main(string[] args)
    {
        kalkuliraj kalkulator = new kalkuliraj();

        Console.WriteLine("Unesi prvi broj: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.ReadLine();

        Console.WriteLine("Unesi drugi broj: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Izaberi operaciju (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar;

        double result = 0;

        switch (operation)
        {
            case '+':
                result = kalkulator.Zbroji(num1, num2);
                break;
            case '-':
                result = kalkulator.Oduzmi(num1, num2);
                break;
            case '/':
                result = kalkulator.Podjeli(num1, num2);
                break;
            case '*':
                result = kalkulator.Pomnozi(num1, num2);
                break;

            default:
                Console.WriteLine("Nepoznata operacija.");
                return;
        }

        Console.WriteLine($"\nRezultat: {result}");
    }
}
