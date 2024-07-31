namespace Calculator_CSharp.OperationAux
{
    public class OperationAux : IOperationAux
    {
        public string UpdateEquation(string equation, double value1, double value2, char symbol, double currentResult, int i)
        {
            equation = equation.Replace($"{value1.ToString()}{symbol.ToString()}{value2.ToString()}", $"{currentResult.ToString()}");

            i = 0;

            return equation;
        }
    }
}