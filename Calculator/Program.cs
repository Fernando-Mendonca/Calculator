using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;

            Console.WriteLine("Calculadora Console em C#\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Digite um numero, e pressione Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro numero, e pressione Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha uma opcao na lista a seguir:");
            Console.WriteLine("\t1 - Adicao");
            Console.WriteLine("\t2 - Subtracao");
            Console.WriteLine("\t3 - Multiplicacao");
            Console.WriteLine("\t4 - Divisao");
            Console.WriteLine("Sua opcao? ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Your result: {num1} + {num2} =  " + (num1 + num2));
                    break;
                case "2":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "3":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "4":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para fechar o aplicativo Calculator app...");
            Console.ReadKey();
        }
    }
}
