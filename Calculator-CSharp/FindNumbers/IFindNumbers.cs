namespace Calculator_CSharp.FindNumbers
{
    public interface IFindNumbers
    {
        public (double, double) FindValues(string equation, int start, char symbol);
    }
}