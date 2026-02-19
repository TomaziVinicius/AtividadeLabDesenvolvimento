class Program
{
    static void Main(string[] args)
    {
        decimal valor = 9.78m;

        float valorConvertido = (float)valor; // casting explícito

        Console.WriteLine("Valor original (decimal): " + valor);
        Console.WriteLine("Valor convertido (float): " + valorConvertido);
    }
}