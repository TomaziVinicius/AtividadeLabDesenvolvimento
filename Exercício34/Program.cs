class Program
{
    static void Main(string[] args)
    {
        double distancia = 17;
        double tempo = 3;

        double velo = 17 / (tempo * 3600);

        Console.WriteLine($"Distância: {distancia} metros");
        Console.WriteLine($"tempo: {tempo} horas");
        Console.WriteLine($"Velocidade média: {velo:N4}m/s");
    }
}