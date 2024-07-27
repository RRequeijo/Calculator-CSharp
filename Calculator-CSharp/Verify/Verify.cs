namespace Calculator_CSharp.Verify
{
    public class Verify : IVerify
    {
        public string Compare(double a, double b)
        {
            if (a > b)
            {
                return $"{a} is greater than {b}";
            }

            if (a < b)
            {
                return $"{a} is smaller than{b}";
            }

            return $"{a} is equal to {b}";
        }

        public bool VerifyEven(int a)
        {
            return a % 2 == 0;
        }

        public bool VerifyPrime(int a)
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
    }
}