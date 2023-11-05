using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {

        static void typeOne()
        {
            Console.Write(
                "Qual tipo de operação você deseja realizar?\n" +
                "[1] Soma\n[2] Subtração\n[3] Multiplicação\n[4] Divisão\n[5] Exponenciação" +
                "\n : "
            );

            int operationB = Convert.ToInt32(Console.ReadLine());
            float num1, num2;
            switch (operationB)
            {
                case 1:

                    Console.Write("Insira o primeiro numero: ");
                    num1 = Convert.ToSingle(Console.ReadLine());

                    Console.Write("Insira o segundo numero: ");
                    num2 = Convert.ToSingle(Console.ReadLine());

                    Console.Write($"O resultado é {num1} + {num2} = {num1 + num2}");
                    break;
                case 2:

                    Console.Write("Insira o primeiro numero: ");
                    num1 = Convert.ToSingle(Console.ReadLine());

                    Console.Write("Insira o segundo numero: ");
                    num2 = Convert.ToSingle(Console.ReadLine());

                    Console.Write($"O resultado é {num1} - {num2} = {num1 - num2}");
                    break;
                case 3:

                    Console.Write("Insira o primeiro numero: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Insira o segundo numero: ");
                    num2 = Convert.ToSingle(Console.ReadLine());

                    Console.Write($"O resultado é {num1} x {num2} = {num1 * num2}");
                    break;
                case 4:

                    Console.Write("Insira o primeiro numero: ");
                    num1 = Convert.ToSingle(Console.ReadLine());

                    Console.Write("Insira o segundo numero: ");
                    num2 = Convert.ToSingle(Console.ReadLine());

                    if (num1 == 0)
                    {
                        Console.WriteLine("Não é possivel dividir 0");
                    }
                    else if (num2 == 0)
                    {
                        Console.WriteLine("Não é possivel dividir por 0");
                    }
                    else
                    {
                        Console.Write($"O resultado é {num1} ÷ {num2} = {num1 / num2}");
                    }

                    break;
                case 5:

                    Console.Write("Insira primeiro a base: ");
                    num1 = Convert.ToSingle(Console.ReadLine());

                    Console.Write("Insira a potencia: ");
                    num2 = Convert.ToSingle(Console.ReadLine());

                    Console.Write($"O resultado de {num1} elevado a {num2} = {Math.Pow(num1, num2)}");

                    break;
                default:

                    Console.WriteLine("Insira um valor valido");
                    break;
            }
        }

        static void typeTwo()
        {
            Console.Write(
                "Qual tipo de operação você deseja realizar?\n" +
                "[1] Raiz Quadrada\n[2] Fatorial\n[3] Logaritimo" +
                "\n : "
            );

            int operation = Convert.ToInt32(Console.ReadLine());
            float num1;
            switch (operation)
            {
                case 1:
                    Console.Write("Qual numero deseja saber a raiz quadrada? ");
                    num1 = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine($"A Raiz quadradra de {num1} é {Math.Sqrt(num1)}");

                    break;
                case 2:
                    Console.Write("Qual numero deseja saber o fatorial? ");
                    num1 = Convert.ToSingle(Console.ReadLine());

                    long res = 1;

                    for (int i = 1; i <= num1; i++)
                    {
                        res *= i;
                    }

                    Console.WriteLine($"O Fatorial de {num1} é {res}");

                    break;
                case 3:
                    Console.Write("Qual numero deseja saber o log? ");
                    num1 = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine($"O log de {num1} é {Math.Log10(num1)}");

                    break;
                default:

                    Console.Write("Insira um valor valido");

                    break;
            }

        }

        static void typeThree()
        {
            Console.Write(
                "Qual tipo de operação você deseja realizar?\n" +
                "[1] Seno\n[2] Cosseno\n[3] Tangente" +
                "\n : "
            );

            int operation = Convert.ToInt32(Console.ReadLine());
            float num1;
            switch (operation)
            {
                case 1:
                    Console.Write("Que numero deseja saber o Seno? ");
                    num1 = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine($"O seno de {num1} é {Math.Sin(num1)}");

                    break;
                case 2:
                    Console.Write("Que numero deseja saber o Coseno? ");
                    num1 = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine($"O cosseno de {num1} é {Math.Cos(num1)}");

                    break;
                case 3:
                    Console.Write("Que numero deseja saber a Tangete? ");
                    num1 = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine($"A tangente de {num1} é {Math.Tan(num1)}");

                    break;
                default:

                    Console.Write("Insira um valor valido");

                    break;
            }
        }

        static void typeFour()
        {
            Console.Write("Quantos números você deseja inserir? ");
            int nums = int.Parse(Console.ReadLine());

            float[] numeros = new float[nums];

            for (int i = 0; i < nums; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                numeros[i] = float.Parse(Console.ReadLine());
            }

            float soma = 0;

            foreach (float numero in numeros)
            {
                soma += numero;
            }

            float media = soma / nums;

            Console.WriteLine($"A média dos números inseridos é: {media}");
        }

        static void Main(string[] args)
        {
            string hifens = new string('-', 10);
            Console.WriteLine($"{hifens} Calculadora {hifens}");

            Console.Write(
                "Você deseja fazer quais operações?" +
                "\n | 1 | Soma, Subtração, Multiplicação, Divisão, Exponenciação" +
                "\n | 2 | Raiz Quadrada, Fatorial, Logaritimo" +
                "\n | 3 | Seno, Cosseno, Tangente" +
                "\n | 4 | Média" +
                "\n :  "
            );

            int typeOp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hifens + hifens + hifens);

            if (typeOp == 1)
            {
                typeOne();
            }
            else if (typeOp == 2)
            {
                typeTwo();
            }
            else if (typeOp == 3)
            {
                typeThree();
            }
            else if (typeOp == 4)
            {
                typeFour();
            }
            else
            {
                Console.Write("Insira um valor valido");
            }

            Console.ReadKey();
        }

    }
}