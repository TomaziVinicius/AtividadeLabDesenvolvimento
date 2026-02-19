class Program
{
    static void Main(string[] args)
    {
        string frase = " Mas os que esperam no Senhor renovarão as forças, subirão com asas como águias; " +
            "correrão, e não se cansarão; caminharão, e não se fatigarão - Isaías 40:31";

        string novafrase = frase.Replace("a", "@").Replace("o", "0");

        Console.WriteLine($"Frase original: {frase}");
        Console.WriteLine($"Nova frase: {novafrase}");

    }
}