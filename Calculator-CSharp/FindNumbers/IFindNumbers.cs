namespace Calculator_CSharp.FindNumbers
{
    public interface IFindNumbers
    {
        (double, double) FindValues(string equation, int start, char symbol);
    }
}