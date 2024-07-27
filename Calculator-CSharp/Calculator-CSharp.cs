namespace Calculator
{
    using Calculator_CSharp;
    using System;

    internal class Calculator
    {
        public static void Main(string[] args)
        {
            BasicOperations bOperations = new BasicOperations();
            Powers powersOperations = new Powers();
            Roots rootsOperations = new Roots();
            Verify verifyOperations = new Verify();

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
                    result = bOperations.Sum(value1, value2);
                    Console.WriteLine($"Result of the Sum from {value1} by {value2}: {result}");
                    break;

                case '-':
                    Console.WriteLine("value 1:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("value 2:");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    result = bOperations.Subtract(value1, value2);
                    Console.WriteLine($"result of Subtraction of {value1} by {value2}: {result}");
                    break;

                case '/':
                    Console.WriteLine("value 1:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("value 2:");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    result = bOperations.Divide(value1, value2);
                    Console.WriteLine($"result of Dividing {value1} by {value2}: {result}");
                    break;

                case '*':
                    Console.WriteLine("value 1:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("value 2:");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    result = bOperations.Multiply(value1, value2);
                    Console.WriteLine($"result of Multiplication of {value1} by {value2}: {result}");
                    break;

                case 'r':
                    Console.WriteLine("value 1:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("value 2:");
                    value2 = Convert.ToDouble(Console.ReadLine());

                    result = bOperations.Rest(value1, value2);
                    Console.WriteLine($"Rest of the division of {value1} by {value2}: {result}");
                    break;

                case '=':
                    Console.WriteLine("value 1:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("value 2:");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    verifyOperations.Compare(value1, value2);
                    break;

                case 'e':
                    Console.WriteLine("value:");
                    value = Convert.ToInt32(Console.ReadLine());
                    verifyOperations.VerifyEven(value);
                    if (verifyOperations.VerifyEven(value) == true)
                    {
                        Console.WriteLine("The number is even.");
                    }
                    if (verifyOperations.VerifyEven(value) == false)
                    {
                        Console.WriteLine("The number is odd.");
                    }
                    break;

                case 'p':
                    Console.WriteLine("value:");
                    value = Convert.ToInt32(Console.ReadLine());
                    verifyOperations.VerifyPrime(value);
                    if (verifyOperations.VerifyEven(value) == false)
                    {
                        Console.WriteLine("The number is prime.");
                    }
                    if (verifyOperations.VerifyEven(value) == true)
                    {
                        Console.WriteLine("The number is not prime.");
                    }
                    break;

                case 'f':
                    Console.WriteLine("value:");
                    value = Convert.ToInt32(Console.ReadLine());
                    result = bOperations.Factorial(value);
                    Console.WriteLine($"The value of {value} in Factorial is {result}");
                    break;

                case 's':
                    Console.WriteLine("value:");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    result = powersOperations.Square(value1);
                    Console.WriteLine($"The frame of {value1} is {result}");
                    break;

                case 'c':
                    Console.WriteLine("value:");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    result = powersOperations.Cube(value1);
                    Console.WriteLine($"The Cube of {value1} is {result}");
                    break;

                case 'S':
                    Console.WriteLine("value:");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    result = rootsOperations.SquareRoot(value1);
                    Console.WriteLine($"The square root of {value1} is {result}");
                    break;

                case 'C':
                    Console.WriteLine("value:");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    result = rootsOperations.CubeRoot(value1);
                    Console.WriteLine($"The cube root of {value1} is {result}");
                    break;

                default:
                    Console.WriteLine("Enter a valid operation");
                    break;
            }
        }
    }
}