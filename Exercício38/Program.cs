class Program
{
    static void Main(string[] args)
    {
        int num = 25;

        bool pos;

        if (num < 0)
        {
            pos = false;
            Console.WriteLine($"O número {num} é negativo");
        }
        else
        {
            pos = true;
            Console.WriteLine($"O número {num} é positivo");
        }
    }
}