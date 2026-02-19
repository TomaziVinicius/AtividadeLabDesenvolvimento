class Program
{
    static void Main(string[] args)
    {
        decimal salario = 1200m;
        decimal novoSalario = salario + salario * 0.10m;

        Console.WriteLine($"Salário atual: {salario}");
        Console.WriteLine($"Novo salário: {novoSalario}");
    }
}