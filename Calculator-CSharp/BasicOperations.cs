namespace Calculator_CSharp
{
    public interface IBasicOperations
    {
        double Divide(double a, double b);

        int Factorial(int a);

        double Multiply(double a, double b);

        double Rest(double a, double b);

        double Subtract(double a, double b);

        double Sum(double a, double b);
    }

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