class Program
{
    static void Main(string[] args)
    {
        string texto = "Sharamanaya";

        string prim = texto.Substring(0, 3);

        Console.WriteLine("Texto original: " + texto);
        Console.WriteLine("3 primeiras letras: " + prim);
    }
}