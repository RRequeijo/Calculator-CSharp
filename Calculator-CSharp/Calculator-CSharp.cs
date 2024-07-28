namespace Calculator
{
    using Calculator_CSharp.BasicOperations;
    using Calculator_CSharp.Powers;
    using Calculator_CSharp.Roots;
    using Calculator_CSharp.Verify;
    using System;

    internal class Calculator
    {
        public static void Main(string[] args)
        {
            BasicOperations basicOperations = new BasicOperations();
            Powers powersOperations = new Powers();
            Roots rootsOperations = new Roots();
            Verify verifyOperations = new Verify();

            Console.WriteLine("Calculator");
            Console.WriteLine("+  Sum");
            Console.WriteLine("-  Subtraction");
            Console.WriteLine("/  Division");
            Console.WriteLine("*  Multiplication");
            Console.WriteLine("r  Rest");
            Console.WriteLine("=  Compare");
            Console.WriteLine("e  Even");
            Console.WriteLine("p  Prime");
            Console.WriteLine("f  Factorial");
            Console.WriteLine("s  Square");
            Console.WriteLine("c  Cube");
            Console.WriteLine("S  SquareRoot");
            Console.WriteLine("C  CubeRoot");
            Console.WriteLine("Enter the symbol of the desired operation:");
            char operation = (char)Console.ReadLine()[0];

            int value = 0;
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

                    result = basicOperations.Sum(value1, value2);
                    Console.WriteLine($"Result of the Sum from {value1} by {value2}: {result}");
                    break;

                case '-':
                    Console.WriteLine("value 1:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("value 2:");
                    value2 = Convert.ToDouble(Console.ReadLine());

                    result = basicOperations.Subtract(value1, value2);
                    Console.WriteLine($"Result of the Subtraction from {value1} by {value2}: {result}");
                    break;

                case '/':
                    Console.WriteLine("value 1:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("value 2:");
                    value2 = Convert.ToDouble(Console.ReadLine());

                    result = basicOperations.Divide(value1, value2);
                    Console.WriteLine($"Result of the Division from {value1} by {value2}: {result}");
                    break;

                case '*':
                    Console.WriteLine("value 1:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("value 2:");
                    value2 = Convert.ToDouble(Console.ReadLine());

                    result = basicOperations.Multiply(value1, value2);
                    Console.WriteLine($"Result of the Multiplication from {value1} by {value2}: {result}");
                    break;

                case 'r':
                    Console.WriteLine("value 1:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("value 2:");
                    value2 = Convert.ToDouble(Console.ReadLine());

                    result = basicOperations.Rest(value1, value2);
                    Console.WriteLine($"Rest of the Division from {value1} by {value2}: {result}");
                    break;

                case '=':
                    Console.WriteLine("value 1:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("value 2:");
                    value2 = Convert.ToDouble(Console.ReadLine());

                    string comparisonResult = verifyOperations.Compare(value1, value2);
                    Console.WriteLine(comparisonResult);
                    break;

                case 'e':
                    Console.WriteLine("value:");
                    value = Convert.ToInt32(Console.ReadLine());

                    if (verifyOperations.VerifyEven(value) == true)
                    {
                        Console.WriteLine("The Number is Even.");
                        break;
                    }

                    Console.WriteLine("The Number is Odd.");

                    break;

                case 'p':
                    Console.WriteLine("value:");
                    value = Convert.ToInt32(Console.ReadLine());

                    if (verifyOperations.VerifyPrime(value) == false)
                    {
                        Console.WriteLine("The Number is Prime.");
                        break;
                    }

                    Console.WriteLine("The Number is Not Prime.");
                    break;

                case 'f':
                    Console.WriteLine("value:");
                    value = Convert.ToInt32(Console.ReadLine());

                    result = basicOperations.Factorial(value);
                    Console.WriteLine($"The Value of {value} in Factorial is {result}");
                    break;

                case 's':
                    Console.WriteLine("value:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    result = powersOperations.Square(value1);
                    Console.WriteLine($"The Frame of {value1} is {result}");
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
                    Console.WriteLine($"The Square Root of {value1} is {result}");
                    break;

                case 'C':
                    Console.WriteLine("value:");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    result = rootsOperations.CubeRoot(value1);
                    Console.WriteLine($"The Cube Root of {value1} is {result}");
                    break;

                default:
                    Console.WriteLine("Enter a valid operation");
                    break;
            }
        }
    }
}