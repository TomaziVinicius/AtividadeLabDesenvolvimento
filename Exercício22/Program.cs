class Program
{
    static void Main(string[] args)
    {
        int numero1 = 15;
        int numero2 = 10;

        Console.WriteLine($"Os números são: {numero1} e {numero2}");
        if (numero1 == numero2)
        {
            Console.WriteLine("Os números são iguais.");
        }
        else if (numero1 > numero2)
        {
            Console.WriteLine("O número 1 é maior que número 2.");
        }
        else
        {
            Console.WriteLine("O número 1 é menor que número 2.");
        }
        if (numero1 != numero2)
        {
            Console.WriteLine("Os números são diferentes.");
        }
        else
        {
            Console.WriteLine("Os números são iguais.");
        }
    }
}