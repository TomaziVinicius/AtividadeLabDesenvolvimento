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

            //---------------------------------------------Exercicio 3---------------------------------------------
            String mensagem = "Uma mensagem qualquer para o exercicio 3";
            Console.WriteLine(mensagem);

            //---------------------------------------------Exercicio 5---------------------------------------------
            Console.WriteLine("Escrevendo qualquer coisa 1");
            Console.WriteLine("Escrevendo qualquer coisa 2");
            Console.WriteLine("Escrevendo qualquer coisa 3");

            //---------------------------------------------Exercicio 7---------------------------------------------
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);

            //---------------------------------------------Exercicio 9---------------------------------------------
            long populacaoBrasil = 200000000;

            //---------------------------------------------Exercicio 11---------------------------------------------
            float temperatura = 36.5f;

            //---------------------------------------------Exercicio 13---------------------------------------------
            String nome = "Vinicius";
            Console.WriteLine("Olá, " + nome);

            //---------------------------------------------Exercicio 15---------------------------------------------
            Console.WriteLine(nome.Length);

            //---------------------------------------------Exercicio 17---------------------------------------------
            char inicialNome = 'V';
            Console.WriteLine(inicialNome);

            //---------------------------------------------Exercicio 19---------------------------------------------
            int idade = 20;
            bool maiorDeIdade = idade >= 20;

            //---------------------------------------------Exercicio 21---------------------------------------------
            bool estaLogado = false;
            Console.WriteLine(!estaLogado);

            //---------------------------------------------Exercicio 23---------------------------------------------
            int umInt = 100;
            long umLong = umInt;
            float umFloat = 3.14f;
            double umDouble = umFloat;

            //---------------------------------------------Exercicio 25---------------------------------------------
            long numeroLong = 3000l;
            int num = (int)numeroLong;

            //---------------------------------------------Exercicio 27---------------------------------------------
            String numeroString = "100";
            Convert.ToInt32(numeroString);
            int numeroEx27 = int.Parse(numeroString);
            

            Console.WriteLine(numeroString);

            //---------------------------------------------Exercicio 29---------------------------------------------
            String texto29 = "abc";
            if (int.TryParse(texto29, out numeroEx27))
            {
                Console.WriteLine(numeroEx27);
            }
               

            //---------------------------------------------Exercicio 31---------------------------------------------
            int int1 = 5;
            int int2 = 8;
            int int3 = 3;

            Console.WriteLine((int1 + int2 + int3) / 3);

            //---------------------------------------------Exercicio 33---------------------------------------------
            int baseT = 30;
            int alturaT = 15;

            Console.WriteLine(baseT * alturaT);

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

            //---------------------------------------------Exercicio 37---------------------------------------------
            String textoGrande = " Texte d ";
            String resultado37 = textoGrande.Trim();
            
            Console.WriteLine(resultado37);

            //---------------------------------------------Exercicio 39---------------------------------------------
            int numero39 = 3;
            bool par39 = (numero39 % 2 == 0);

            Console.WriteLine(par39);


            //---------------------------------------------Exercicio 41---------------------------------------------
            double numero41 = 40.912398127398d;
            
            Console.WriteLine(Math.Round(numero41, 2));

            //---------------------------------------------Exercicio 43---------------------------------------------
            String numero43 = "3323";
            Convert.ToDouble(numero43);

            Console.WriteLine(numero43);

            //---------------------------------------------Exercicio 45---------------------------------------------
            String texto45 = "dez";
            bool numeralValido = int.TryParse(texto45, out int resultado45);

            Console.WriteLine(resultado45);

            //---------------------------------------------Exercicio 47---------------------------------------------
            float altura47 = 1.83f;
            Convert.ToDouble(altura47);

            //---------------------------------------------Exercicio 49---------------------------------------------
            String texto49 = "Texte de Texto procurando Texto";
            bool validaTexto49 = texto49.Contains('t');

            Console.WriteLine(validaTexto49);

            //---------------------------------------------Exercicio 51---------------------------------------------
            bool ativo = true;
            Console.WriteLine(!ativo);

            //---------------------------------------------Exercicio 53---------------------------------------------
            String texto53 = "";

            int tamanho53 = texto53.Length;

            //---------------------------------------------Exercicio 55---------------------------------------------
            int numero55 = 64;

            Console.WriteLine(Math.Sqrt(numero55));

            //---------------------------------------------Exercicio 57---------------------------------------------
            byte numero57 = 256;

            Console.WriteLine(numero57);
            //---------------------------------------------Exercicio 59---------------------------------------------
            double numero59 = 66.75;

            float numeroFloat59 = (float)numero59;

        }
    }
}
