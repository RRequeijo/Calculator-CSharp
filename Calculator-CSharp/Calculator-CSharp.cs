namespace Calculator
{
    using System;

    /// <summary>
    /// <see cref="Calculator"/>
    /// </summary>
    internal class Calculator
    {
        public static double Cube(double a)
        {
            return a * a * a;
        }

        public static double CubeRoot(double a)
        {
            if (a < 0)
            {
                return 0;
            }
            return Math.Cbrt(a);
        }

        public static int Factorial(int a)
        {
            int total = a;

            for (int i = a - 1; i >= 1; i--)
            {
                total *= i;
            }
            return total;
        }

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("+  Sum \n-  Subtraction \n/  Division \n*  Multiplication \nr  Rest \n=  Compare \ne  Even \np  Prime \nf  Factorial \ns  Square \nc  Cube \nS  SquareRoot \nC  CubeRoot");
            Console.WriteLine("Enter the symbol of the desired operation:");
            char operation = Console.ReadLine()[0];

            int value;
            double value1 = 0;
            double value2 = 0;

            double result = 0;

            switch (operation)
            {
                case '+':
                    Console.WriteLine("value 1:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("value 2:");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    result = Sum(value1, value2);
                    Console.WriteLine($"Result of the Sum from {value1} by {value2}: {result}");
                    break;

                case '-':
                    Console.WriteLine("value 1:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("value 2:");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    result = Subtract(value1, value2);
                    Console.WriteLine($"result of Subtraction of {value1} by {value2}: {result}");
                    break;

                case '/':
                    Console.WriteLine("value 1:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("value 2:");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    result = Divide(value1, value2);
                    Console.WriteLine($"result of Dividing {value1} by {value2}: {result}");
                    break;

                case '*':
                    Console.WriteLine("value 1:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("value 2:");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    result = Multiply(value1, value2);
                    Console.WriteLine($"result of Multiplication of {value1} by {value2}: {result}");
                    break;

                case 'r':
                    Console.WriteLine("value 1:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("value 2:");
                    value2 = Convert.ToDouble(Console.ReadLine());

                    result = Rest(value1, value2);
                    Console.WriteLine($"Rest of the division of {value1} by {value2}: {result}");
                    break;

                case '=':
                    Console.WriteLine("value 1:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("value 2:");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    Compare(value1, value2);
                    break;

                case 'e':
                    Console.WriteLine("value:");
                    value = Convert.ToInt32(Console.ReadLine());
                    VerifyEven(value);
                    if (VerifyEven(value) == true)
                    {
                        Console.WriteLine("The number is even.");
                    }
                    if (VerifyEven(value) == false)
                    {
                        Console.WriteLine("The number is odd.");
                    }
                    break;

                case 'p':
                    Console.WriteLine("value:");
                    value = Convert.ToInt32(Console.ReadLine());
                    VerifyPrime(value);
                    if (VerifyEven(value) == false)
                    {
                        Console.WriteLine("The number is prime.");
                    }
                    if (VerifyEven(value) == true)
                    {
                        Console.WriteLine("The number is not prime.");
                    }
                    break;

                case 'f':
                    Console.WriteLine("value:");
                    value = Convert.ToInt32(Console.ReadLine());
                    result = Factorial(value);
                    Console.WriteLine($"The value of {value} in Factorial is {result}");
                    break;

                case 's':
                    Console.WriteLine("value:");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    result = Square(value1);
                    Console.WriteLine($"The frame of {value1} is {result}");
                    break;

                case 'c':
                    Console.WriteLine("value:");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    result = Cube(value1);
                    Console.WriteLine($"The Cube of {value1} is {result}");
                    break;

                case 'S':
                    Console.WriteLine("value:");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    result = SquareRoot(value1);
                    Console.WriteLine($"The square root of {value1} is {result}");
                    break;

                case 'C':
                    Console.WriteLine("value:");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    result = CubeRoot(value1);
                    Console.WriteLine($"The cube root of {value1} is {result}");
                    break;

                default:
                    Console.WriteLine("Enter a valid operation");
                    break;
            }
        }

        public static double Square(double a)
        {
            return a * a;
        }

        public static double SquareRoot(double a)
        {
            if (a < 0)
            {
                return 0;
            }
            return Math.Sqrt(Math.Sqrt(a));
        }

        public static bool VerifyEven(int a)
        {
            return a % 2 == 0;
        }

        public static bool VerifyPrime(int a)
        {
            if (a <= 1)
            {
                return false;
            }

            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Compares the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        private static void Compare(double a, double b)
        {
            if (a > b)
            {
                Console.WriteLine($"{a} is greater than {b}");
            }
            if (a < b)
            {
                Console.WriteLine($"{a} is smaller {b}");
            }
            Console.WriteLine($"{a} is equal to {b}");
        }

        /// <summary>
        /// Divides the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        private static double Divide(double a, double b)
        {
            return a / b;
        }

        /// <summary>
        /// Multiplys the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        private static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Restes the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        private static double Rest(double a, double b)
        {
            return a % b;
        }

        /// <summary>
        /// Subtracts the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        private static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Sums the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        private static double Sum(double a, double b)
        {
            return a + b;
        }
    }
}