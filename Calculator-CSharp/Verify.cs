namespace Calculator_CSharp
{
    public interface IVerify
    {
        void Compare(double a, double b);

        bool VerifyEven(int a);

        bool VerifyPrime(int a);
    }

    public class Verify : IVerify
    {
        public void Compare(double a, double b)
        {
            if (a > b)
            {
                Console.WriteLine($"{a} is greater than {b}");
                return;
            }
            if (a < b)
            {
                Console.WriteLine($"{a} is smaller {b}");
                return;
            }
            Console.WriteLine($"{a} is equal to {b}");
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