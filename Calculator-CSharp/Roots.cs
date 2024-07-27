namespace Calculator_CSharp
{
    using System;

    public interface IRoots
    {
        double CubeRoot(double a);

        double SquareRoot(double a);
    }

    public class Roots : IRoots
    {
        public double CubeRoot(double a)
        {
            if (a < 0)
            {
                return 0;
            }
            return Math.Cbrt(a);
        }

        public double SquareRoot(double a)
        {
            if (a < 0)
            {
                return 0;
            }
            return Math.Sqrt(Math.Sqrt(a));
        }
    }
}