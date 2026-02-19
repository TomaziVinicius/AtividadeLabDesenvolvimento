class Program { 
    static void Main(string[] args) { 

        decimal desconto = 17m; 
        decimal preço = 3500m; 

        decimal valorFinal = preço - (desconto / 100 * preço); 

        Console.WriteLine($"Valor do produto sem desconto: {preço}"); 
        Console.WriteLine($"Valor do produto com desconto de 17%: {valorFinal}"); 
    } 
}