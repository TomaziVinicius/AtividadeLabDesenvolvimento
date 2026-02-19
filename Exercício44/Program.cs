class Program
{
    static void Main(string[] args)
    {
        string entrada = "1000";

        if (int.TryParse(entrada, out int numero))
        {
            Console.WriteLine("Valor válido!");
            Console.WriteLine($"Número convertido: {numero}");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}