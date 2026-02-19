class Program
{
    static void Main(string[] args)
    {
        string texto = "250";

        if (int.TryParse(texto, out int numero))
        {
            Console.WriteLine("Conversão realizada com sucesso!");
            Console.WriteLine("Número convertido: " + numero);
        }
        else
        {
            Console.WriteLine("Não foi possível converter.");
        }
    }
}