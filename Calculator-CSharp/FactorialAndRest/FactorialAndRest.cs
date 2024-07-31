namespace Calculator_CSharp.FactorialAndRest
{
    public class FactorialAndRest : IFactorialAndRest
    {
        public int Factorial(int a)
        {
            int total = a;

            for (int i = a - 1; i >= 1; i--)
            {
                total *= i;
            }

            return total;
        }

        public double Rest(double a, double b)
        {
            return a % b;
        }
    }
}