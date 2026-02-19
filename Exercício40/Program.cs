class Program
{
    static void Main(string[] args)
    {
        string frase1 = "Shemah Israel, adonai elohenu";

        string frase2 = "SHEMAH ISRAEL    , ADONAI ELOHENU";


        Console.WriteLine($"Frase 1: {frase1}");
        Console.WriteLine($"Frase 2: {frase2}");

        bool frases = frase1.Equals(frase2);

        if (frases == true)
        {
            Console.WriteLine("As frases são iguais");
        }
        else
        {
            Console.WriteLine("As frases não são iguais");
        }
    }
}