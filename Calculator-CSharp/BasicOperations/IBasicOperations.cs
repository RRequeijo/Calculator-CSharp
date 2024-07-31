namespace Calculator_CSharp.Priority
{
    public interface IBasicOperations
    {
        public double CalculateFinalResult(string equation);

        public string DivisionAndMultiplication(string equation);

        public double SubtractionAndAdiction(string equation);
    }
}