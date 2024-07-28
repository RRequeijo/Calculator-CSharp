namespace Calculator_CSharp.Powers
{
    public class Powers : IPowers
    {
        public double Cube(double a)
        {
            return a * a * a;
        }

        public double Square(double a)
        {
            return a * a;
        }
    }
}