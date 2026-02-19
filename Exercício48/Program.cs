class Program
{
    static void Main(string[] args)
    {
        long numero = 999999999999999999;
        int numConvert = (int)numero;

        Console.WriteLine($"Número do tipo long: {numero}");
        Console.WriteLine($"Número convertido para int: {numConvert}");
    }
}