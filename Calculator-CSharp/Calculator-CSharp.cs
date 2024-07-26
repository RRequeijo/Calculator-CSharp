namespace Calculadora
{
    using System;

    internal class Calculadora
    {
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
            double division = 1;
            int i = 0;

            do
            {
                i++;
                Console.WriteLine($"{i}o value:");
                value = double.Parse(Console.ReadLine());
                if (value != 0)
                {
                    if (i == 1)
                    {
                        division *= value;
                    }
                    if (i > 1)
                    {
                        division /= value;
                    }
                }
            }
            while (value != 0);

            return division;
        }

        private static double Multiplication()
        {
            double value;
            double multiplication = 1;
            int i = 0;

            do
            {
                i++;
                Console.WriteLine($"{i}o value:");
                value = double.Parse(Console.ReadLine());
                if (value != 0)
                {
                    multiplication *= value;
                }
            }
            while (value != 0);

            return multiplication;
        }

        private static double Subtraction()
        {
            double value = 0;
            double subtraction = 0;
            int i = 0;

            do
            {
                i++;
                Console.WriteLine($"{i}o value:");
                value = double.Parse(Console.ReadLine());

                if (i == 1)
                {
                    subtraction += value;
                }
                if (i > 1)
                {
                    subtraction -= value;
                }
            }
            while (value != 0);

            return subtraction;
        }

        private static double Sum()
        {
            double value = 0;
            double sum = 0;
            int i = 0;

            do
            {
                i++;
                Console.WriteLine($"{i}o value:");
                value = double.Parse(Console.ReadLine());
                sum += value;
            }
            while (value != 0);

            return sum;
        }
    }
}