using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------Exercicio 1---------------------------------------------
            Console.WriteLine("Hellow World");

            //---------------------------------------------Exercicio 2---------------------------------------------
            Console.WriteLine("Nome: Lucas Lima");
            Console.WriteLine("Idade: 25 anos");
            Console.WriteLine("Curso: Análise e Desenvolvimento de Sistemas");

            //---------------------------------------------Exercicio 3---------------------------------------------
            String mensagem = "Uma mensagem qualquer para o exercicio 3";
            Console.WriteLine(mensagem);

            //---------------------------------------------Exercicio 4---------------------------------------------
            int anoAtual = 2026;
            Console.WriteLine($"Estamos em {anoAtual}");

            //---------------------------------------------Exercicio 5---------------------------------------------
            Console.WriteLine("Escrevendo qualquer coisa 1");
            Console.WriteLine("Escrevendo qualquer coisa 2");
            Console.WriteLine("Escrevendo qualquer coisa 3");

            //---------------------------------------------Exercicio 6---------------------------------------------
            int idade = 23;
            double altura = 1.60;
            double peso = 70.500;
            decimal salario = 27000;
            Console.WriteLine("Idade: " + idade + "\nAltura: " + altura + "\nPeso: " + peso + "\nSalário: R$" + salario + "");
    
            //---------------------------------------------Exercicio 7---------------------------------------------
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);

            //---------------------------------------------Exercicio 8---------------------------------------------
            decimal salario = 199.99m;
            Console.WriteLine($"Salario em reais: R${salario:N2}");

            //---------------------------------------------Exercicio 9---------------------------------------------
            long populacaoBrasil = 200000000;

            //---------------------------------------------Exercicio 10---------------------------------------------
            byte nivel = 10;
            Console.WriteLine("Nível: " + nivel);

            //---------------------------------------------Exercicio 11---------------------------------------------
            float temperatura = 36.5f;

            //---------------------------------------------Exercicio 12---------------------------------------------
            int num = 7;
            Console.WriteLine($"Número: {num} \nDobro: {num*2} \nTriplo: {num*3}");

            //---------------------------------------------Exercicio 13---------------------------------------------
            String nome = "Vinicius";
            Console.WriteLine("Olá, " + nome);

            //---------------------------------------------Exercicio 14---------------------------------------------
            string nome = "Misael";
            string sobrenome = "Saad";
            string nomeCompleto = nome + " " + sobrenome;
            Console.WriteLine($"Nome completo: {nomeCompleto}");

            //---------------------------------------------Exercicio 15---------------------------------------------
            Console.WriteLine(nome.Length);

            //---------------------------------------------Exercicio 16---------------------------------------------
            string frase = "Os que confiam no Senhor são como o monte Sião que não se abala.";
            string frasemin = frase.ToLower();
            string frasemai = frase.ToUpper();
            Console.WriteLine($"{frase} \n{frasemin} \n{frasemai}");

            //---------------------------------------------Exercicio 17---------------------------------------------
            char inicialNome = 'V';
            Console.WriteLine(inicialNome);

            //---------------------------------------------Exercicio 18---------------------------------------------
            string frase = "Meu nome é Lucas Gabriel.";
            string novaFrase = frase.Replace("Lucas Gabriel", "Optimus Prime");
            Console.WriteLine(novaFrase);

            //---------------------------------------------Exercicio 19---------------------------------------------
            int idade = 20;
            bool maiorDeIdade = idade >= 20;
            //---------------------------------------------Exercicio 20---------------------------------------------
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

            //---------------------------------------------Exercicio 21---------------------------------------------
            bool estaLogado = false;
            Console.WriteLine(!estaLogado);
            //---------------------------------------------Exercicio 22---------------------------------------------
            int numero1 = 15;
            int numero2 = 10;

            Console.WriteLine($"Os números são: {numero1} e {numero2}");
            if (numero1 == numero2)
            {
                Console.WriteLine("Os números são iguais.");
            }
            else if (numero1 > numero2)
            {
                Console.WriteLine("O número 1 é maior que número 2.");
            }
            else
            {
                Console.WriteLine("O número 1 é menor que número 2.");
            }
            if (numero1 != numero2)
            {
                Console.WriteLine("Os números são diferentes.");
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }

            //---------------------------------------------Exercicio 23---------------------------------------------
            int umInt = 100;
            long umLong = umInt;
            float umFloat = 3.14f;
            double umDouble = umFloat;
            //---------------------------------------------Exercicio 24---------------------------------------------
            double valor = 9.78;
            int valorConvertido = (int)valor;
            Console.WriteLine("Valor original (double): " + valor);
            Console.WriteLine("Valor convertido (int): " + valorConvertido);

            //---------------------------------------------Exercicio 25---------------------------------------------
            long numeroLong = 3000l;
            int num = (int)numeroLong;
            //---------------------------------------------Exercicio 26---------------------------------------------
            decimal valor = 9.78m;
            float valorConvertido = (float)valor; // casting explícito
            Console.WriteLine("Valor original (decimal): " + valor);
            Console.WriteLine("Valor convertido (float): " + valorConvertido);

            //---------------------------------------------Exercicio 27---------------------------------------------
            String numeroString = "100";
            Convert.ToInt32(numeroString);
            int numeroEx27 = int.Parse(numeroString);
            Console.WriteLine(numeroString);

            //---------------------------------------------Exercicio 28---------------------------------------------
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

            //---------------------------------------------Exercicio 29---------------------------------------------
            String texto29 = "abc";
            if (int.TryParse(texto29, out numeroEx27))
            {
                Console.WriteLine(numeroEx27);
            }
               
            //---------------------------------------------Exercicio 30---------------------------------------------
            string texto = "500.75";
            double valorDouble = Convert.ToDouble(texto);
            int valorInt = (int)valorDouble;
            Console.WriteLine("Valor em double: " + valorDouble);
            Console.WriteLine("Valor em int (após casting): " + valorInt);

            //---------------------------------------------Exercicio 31---------------------------------------------
            int int1 = 5;
            int int2 = 8;
            int int3 = 3;

            Console.WriteLine((int1 + int2 + int3) / 3);
            //---------------------------------------------Exercicio 32---------------------------------------------
            decimal desconto = 17m; 
            decimal preço = 3500m; 
            decimal valorFinal = preço - (desconto / 100 * preço); 
            Console.WriteLine($"Valor do produto sem desconto: {preço}"); 
            Console.WriteLine($"Valor do produto com desconto de 17%: {valorFinal}");

            //---------------------------------------------Exercicio 33---------------------------------------------
            int baseT = 30;
            int alturaT = 15;
            Console.WriteLine(baseT * alturaT);

            //---------------------------------------------Exercicio 34---------------------------------------------
            double distancia = 17;
            double tempo = 3;
            double velo = 17 / (tempo * 3600);
            Console.WriteLine($"Distância: {distancia} metros");
            Console.WriteLine($"tempo: {tempo} horas");
            Console.WriteLine($"Velocidade média: {velo:N4}m/s");

            //---------------------------------------------Exercicio 35---------------------------------------------
            char veri35 = 'C';
            if(veri35 == 'A')
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            //---------------------------------------------Exercicio 36---------------------------------------------
            string texto = "Sharamanaya";
            string prim = texto.Substring(0, 3);
            Console.WriteLine("Texto original: " + texto);
            Console.WriteLine("3 primeiras letras: " + prim);

            //---------------------------------------------Exercicio 37---------------------------------------------
            String textoGrande = " Texte d ";
            String resultado37 = textoGrande.Trim();
            
            Console.WriteLine(resultado37);
            //---------------------------------------------Exercicio 38---------------------------------------------
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

            //---------------------------------------------Exercicio 39---------------------------------------------
            int numero39 = 3;
            bool par39 = (numero39 % 2 == 0);

            Console.WriteLine(par39);

            //---------------------------------------------Exercicio 40---------------------------------------------
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

            //---------------------------------------------Exercicio 41---------------------------------------------
            double numero41 = 40.912398127398d;
            
            Console.WriteLine(Math.Round(numero41, 2));
            //---------------------------------------------Exercicio 42---------------------------------------------
            int numero = 320;
            string numeroConvert = numero.ToString();
            Console.WriteLine($"O número em string é: {numeroConvert}");

            //---------------------------------------------Exercicio 43---------------------------------------------
            String numero43 = "3323";
            Convert.ToDouble(numero43);

            Console.WriteLine(numero43);
            //---------------------------------------------Exercicio 44---------------------------------------------
            string entrada = "1000";
            if (int.TryParse(entrada, out int numero))
            {
                Console.WriteLine("Valor válido!");
                Console.WriteLine($"Número convertido: {numero}");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }

            //---------------------------------------------Exercicio 45---------------------------------------------
            String texto45 = "dez";
            bool numeralValido = int.TryParse(texto45, out int resultado45);

            Console.WriteLine(resultado45);
            //---------------------------------------------Exercicio 46---------------------------------------------
            decimal salario = 1200m;
            decimal novoSalario = salario + salario * 0.10m;
            Console.WriteLine($"Salário atual: {salario}");
            Console.WriteLine($"Novo salário: {novoSalario}");

            //---------------------------------------------Exercicio 47---------------------------------------------
            float altura47 = 1.83f;
            Convert.ToDouble(altura47);
            //---------------------------------------------Exercicio 48---------------------------------------------
            long numero = 999999999999999999;
            int numConvert = (int)numero;
            Console.WriteLine($"Número do tipo long: {numero}");
            Console.WriteLine($"Número convertido para int: {numConvert}");

            //---------------------------------------------Exercicio 49---------------------------------------------
            String texto49 = "Texte de Texto procurando Texto";
            bool validaTexto49 = texto49.Contains('t');

            Console.WriteLine(validaTexto49);
            //---------------------------------------------Exercicio 50---------------------------------------------
            string frase = " Mas os que esperam no Senhor renovarão as forças, subirão com asas como águias; " +
            "correrão, e não se cansarão; caminharão, e não se fatigarão - Isaías 40:31";
            string novafrase = frase.Replace("a", "@").Replace("o", "0");
            Console.WriteLine($"Frase original: {frase}");
            Console.WriteLine($"Nova frase: {novafrase}");

            //---------------------------------------------Exercicio 51---------------------------------------------
            bool ativo = true;
            Console.WriteLine(!ativo);
            //---------------------------------------------Exercicio 52---------------------------------------------
            int numero1 = 15;
            int numero2 = 10;
            if (numero1 > numero2)
            {
                Console.WriteLine($"{numero1} é maior que {numero2}");
            }
            else
            {
                Console.WriteLine($"{numero2} é maior que {numero1}");
            }

            //---------------------------------------------Exercicio 53---------------------------------------------
            String texto53 = "";

            int tamanho53 = texto53.Length;
            //---------------------------------------------Exercicio 54---------------------------------------------
            decimal valor = 12.7m;
            int valorConvertido = (int)Math.Round(valor);
            Console.WriteLine($"Valor decimal: {valor}");
            Console.WriteLine($"Valor convertido para int: {valorConvertido}");

            //---------------------------------------------Exercicio 55---------------------------------------------
            int numero55 = 64;

            Console.WriteLine(Math.Sqrt(numero55));
            //---------------------------------------------Exercicio 56---------------------------------------------
            string num1 = "27";
            string num2 = "32";
            int numa = int.Parse(num1);
            int numb = int.Parse(num2);
            int soma = numa + numb;
            Console.WriteLine($"A soma de {num1} e {num2} resulta em {soma}");

            //---------------------------------------------Exercicio 57---------------------------------------------
            byte numero57 = 256;

            Console.WriteLine(numero57);
            //---------------------------------------------Exercicio 58---------------------------------------------
            int numeroInt = 1500;
            long numeroLong = numeroInt; 
            Console.WriteLine($"Valor no tipo int: {numeroInt}");
            Console.WriteLine($"Valor no tipo long: {numeroLong}");

            //---------------------------------------------Exercicio 59---------------------------------------------
            double numero59 = 66.75;
            float numeroFloat59 = (float)numero59;

            //---------------------------------------------Exercicio 60---------------------------------------------
            string nome = "Lucas";
            int idade = 23;
            decimal salario = 2500.75m;
            Console.WriteLine($"Nome: {nome} \nIdade: {idade} anos \nSalário: R$ {salario:N2}");

        }
    }
}
