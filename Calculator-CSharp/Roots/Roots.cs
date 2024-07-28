namespace Calculator_CSharp.Roots
{
    using System;

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

            return Math.Sqrt(a);
        }
    }
}