namespace Calculator_CSharp
{
    public interface IPowers
    {
        double Cube(double a);

        double Square(double a);
    }

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