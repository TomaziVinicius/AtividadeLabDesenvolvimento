class Program
{
    static void Main(string[] args)
    {
        string texto = "500.75";

        double valorDouble = Convert.ToDouble(texto);

        int valorInt = (int)valorDouble;

        Console.WriteLine("Valor em double: " + valorDouble);
        Console.WriteLine("Valor em int (após casting): " + valorInt);
    }
}