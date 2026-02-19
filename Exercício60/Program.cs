class Program
{
    static void Main(string[] args)
    {
        string nome = "Lucas";
        int idade = 23;
        decimal salario = 2500.75m;

        Console.WriteLine($"Nome: {nome} \nIdade: {idade} anos \nSalário: R$ {salario:N2}");
    }
}