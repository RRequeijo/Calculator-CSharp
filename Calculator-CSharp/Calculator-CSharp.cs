namespace Calculadora
{
    using System;

    internal class Calculadora
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("+  Sum \n-  Subtraction \n/  Division \n*  Multiplication");
            Console.WriteLine("Enter the symbol of the desired operation(enter 0 to end): \n");
            char operacao = Console.ReadLine()[0];

            double result = 0;

            switch (operacao)
            {
                case '+':
                    result = Sum();
                    Console.WriteLine($"Sum Result:{result}");
                    break;

                case '-':
                    result = Subtraction();
                    Console.WriteLine($"Subtraction Result :{result}");
                    break;

                case '/':
                    result = Division();
                    Console.WriteLine($"Division Result:{result}");
                    break;

                case '*':
                    result = Multiplication();
                    Console.WriteLine($"Multiplication Result:{result}");
                    break;

                default:
                    Console.WriteLine("Enter a valid operation");
                    break;
            }
        }

        private static double Division()
        {
            double value;
            double temp = 0;
            double division = 0;
            int i = 1;

            Console.WriteLine("1o value:");
            value = double.Parse(Console.ReadLine());
            temp = value;
            while (value != 0)
            {
                i++;
                Console.WriteLine($"{i}o value:");
                value = double.Parse(Console.ReadLine());
                temp /= value;
            }

            return division = temp;
        }

        private static double Multiplication()
        {
            double value;
            double multiplication = 1;
            int i = 1;

            Console.WriteLine("1o value:");
            value = double.Parse(Console.ReadLine());
            while (value != 0)
            {
                i++;
                multiplication *= value;
                Console.WriteLine($"{i}o value:");
                value = double.Parse(Console.ReadLine());
            }

            return multiplication;
        }

        private static double Subtraction()
        {
            double value = 0;
            double subtraction = 0;
            int i = 1;

            Console.WriteLine("1o value:");
            value = double.Parse(Console.ReadLine());
            subtraction = value;
            while (value != 0)
            {
                i++;
                Console.WriteLine($"{i}o value:");
                value = double.Parse(Console.ReadLine());
                subtraction -= value;
            }

            return subtraction;
        }

        private static double Sum()
        {
            double value;
            double sum = 0;
            int i = 1;

            Console.WriteLine("1o value:");
            value = double.Parse(Console.ReadLine());

            while (value != 0)
            {
                i++;
                sum += value;
                Console.WriteLine($"{i}o value:");
                value = double.Parse(Console.ReadLine());
            }

            return sum;
        }
    }
}