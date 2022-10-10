using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("===============Calculadora================"); // definir o titulo do programa

            //atributos globais
            double num1, num2, resultado;
            string operador= "";

            Console.WriteLine("MENU DA CALCULADORA");
            Console.WriteLine("+ adição");
            Console.WriteLine("- subtração");
            Console.WriteLine("/ divisão");
            Console.WriteLine("* multiplicação");
            Console.WriteLine("s sair");

            Console.WriteLine("Seleciona uma opção (operador):");
             operador = Console.ReadLine();
            if (operador == "s")
            {
                Environment.Exit(0);
            }
          
            //leitura das variaveis
            Console.WriteLine("Introduza o Primeiro numero a operar");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o Segundo numero a operar");
            num2 = int.Parse(Console.ReadLine());

            //switch case para ver qual a operação utilizada
             switch (operador)
             {
                case "+":
                    resultado = num1 + num2;
                    Console.WriteLine($"{num1} {operador} {num2} = {resultado}");
                    Main();
                    break;

                case "-":
                    resultado = num1 - num2;
                    Console.WriteLine($"{num1} {operador} {num2} = {resultado}");
                    Main();
                    break;

                case "/":
                    resultado = num1 / num2;
                    Console.WriteLine($"{num1} {operador} {num2} = {resultado}");
                    Main();
                    break;

                case "%":
                    resultado = num1 % num2;
                    Console.WriteLine($"{num1} {operador} {num2} = {resultado}");
                    Main();
                    break;

                case "*":
                    resultado = num1 * num2;
                    Console.WriteLine($"{num1} {operador} {num2} = {resultado}");
                    Main();
                    break;
            }

            Console.ReadLine();
        }
    }
}
