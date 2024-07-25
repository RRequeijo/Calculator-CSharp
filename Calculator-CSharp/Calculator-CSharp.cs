namespace Calculadora
{
    using System;

    /// <summary>
    /// <see cref="Calculadora"/>
    /// </summary>
    internal class Calculadora
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("+  Soma \n-  Subtracao \n/  Divisao \n*  Multiplicacao \nr  Resto \n=  Comparar");
            Console.WriteLine("Digita o simbolo da operação desejada: \n");
            char operacao = Console.ReadLine()[0];

            Console.WriteLine("Valor 1:");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor 2:");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (operacao)
            {
                case '+':
                    resultado = Somar(valor1, valor2);
                    Console.WriteLine($"Resultado da Soma de {valor1} por {valor2}: {resultado}");
                    break;

                case '-':
                    resultado = Subtrair(valor1, valor2);
                    Console.WriteLine($"Resultado da Subtracao de {valor1} por {valor2}: {resultado}");
                    break;

                case '/':
                    resultado = Dividir(valor1, valor2);
                    Console.WriteLine($"Resultado da Divisao de {valor1} por {valor2}: {resultado}");
                    break;

                case '*':
                    resultado = Multiplicar(valor1, valor2);
                    Console.WriteLine($"Resultado da Multiplicacao de {valor1} por {valor2}: {resultado}");
                    break;

                case 'r':
                    resultado = Resto(valor1, valor2);
                    Console.WriteLine($"Resto da divisao de {valor1} por {valor2}: {resultado}");
                    break;

                case '=':
                    Comparar(valor1, valor2);
                    break;

                default:
                    {
                        Console.WriteLine("Insira uma operação válida");
                        break;
                    }
            }
        }

        /// <summary>
        /// Comparars the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        private static void Comparar(double a, double b)
        {
            if (a > b)
            {
                Console.WriteLine($"{a} é maior que {b}");
            }
            if (a < b)
            {
                Console.WriteLine($"{a} é menor {b}");
            }
            if (a == b)
            {
                Console.WriteLine($"{a} é igual a {b}");
            }
        }

        /// <summary>
        /// Dividirs the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        private static double Dividir(double a, double b)
        {
            return a / b;
        }

        /// <summary>
        /// Multiplicars the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        private static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Restoes the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        private static double Resto(double a, double b)
        {
            return a % b;
        }

        /// <summary>
        /// Somars the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        private static double Somar(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtrairs the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        private static double Subtrair(double a, double b)
        {
            return a - b;
        }
    }
}