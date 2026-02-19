class Program
{
    static void Main(string[] args)
    {
        decimal valor = 12.7m;

        int valorConvertido = (int)Math.Round(valor);

        Console.WriteLine($"Valor decimal: {valor}");
        Console.WriteLine($"Valor convertido para int: {valorConvertido}");
    }
}