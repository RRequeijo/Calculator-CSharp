namespace Calculator_CSharp.BasicOperations
{
    public class BasicOperations : IBasicOperations
    {
        public double Divide()
        {
            double value = 0;
            double division = 0;
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
                        division = value;
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

        public int Factorial(int a)
        {
            int total = a;

            for (int i = a - 1; i >= 1; i--)
            {
                total *= i;
            }

            return total;
        }

        public double Multiply()
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

        public double Rest(double a, double b)
        {
            return a % b;
        }

        public double Subtract()
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
                    subtraction = value;
                }

                if (i > 1)
                {
                    subtraction -= value;
                }
            }
            while (value != 0);

            return subtraction;
        }

        public double Sum()
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