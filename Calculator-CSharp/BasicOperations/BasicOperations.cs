namespace Calculator_CSharp.BasicOperations
{
    public class BasicOperations : IBasicOperations
    {
        public double Divide(double a, double b)
        {
            return a / b;
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

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Rest(double a, double b)
        {
            return a % b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Sum(double a, double b)
        {
            return a + b;
        }
    }
}