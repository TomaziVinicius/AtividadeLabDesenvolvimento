class Program
{
    static void Main(string[] args)
    {
        string frase = "Os que confiam no Senhor são como o monte Sião que não se abala.";

        string frasemin = frase.ToLower();
        string frasemai = frase.ToUpper();

        Console.WriteLine($"{frase} \n{frasemin} \n{frasemai}");
    }
}