namespace Calculator_CSharp.OperationAux
{
    internal interface IOperationAux
    {
        string UpdateEquation(string equation, double value1, double value2, char symbol, double currentResult, int i);
    }
}