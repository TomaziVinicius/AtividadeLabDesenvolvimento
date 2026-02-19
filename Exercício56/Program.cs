class Program
{
    static void Main(string[] args)
    {
        string num1 = "27";
        string num2 = "32";

        int numa = int.Parse(num1);
        int numb = int.Parse(num2);

        int soma = numa + numb;

        Console.WriteLine($"A soma de {num1} e {num2} resulta em {soma}");

    }
}