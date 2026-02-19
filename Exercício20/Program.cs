class Program
{
    static void Main(string[] args)
    {
        bool temCartao = false;
        bool saldoSuficiente = true;

        if (temCartao && saldoSuficiente)
        {
            Console.WriteLine("Compra aprovada!");
        }
        else
        {
            Console.WriteLine("Compra negada!");
        }
    }
}