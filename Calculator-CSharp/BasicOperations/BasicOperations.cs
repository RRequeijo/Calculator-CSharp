namespace Calculator_CSharp.BasicOperations
{
    using Calculator_CSharp.FindNumbers;
    using Calculator_CSharp.OperationAux;
    using System.Text;

    public class BasicOperations : IBasicOperations
    {
        private FindNumbers findNumbers = new FindNumbers();
        private OperationAux operationAux = new OperationAux();

        public double CalculateFinalResult(string equation)
        {
            string priority1stOperations = DivisionAndMultiplication(equation);

            double priority2ndOperations = SubtractionAndAdiction(priority1stOperations);

            return priority2ndOperations;
        }

        public string DivisionAndMultiplication(string equation)
        {
            StringBuilder newEquation = new StringBuilder();
            double currentResult = 0;
            int i = 0;

            while (i < equation.Length)
            {
                if (equation[i] == '*' || equation[i] == '/')
                {
                    char symbol = equation[i];
                    var values = findNumbers.FindValues(equation, i, symbol);

                    double value1 = values.Item1;
                    double value2 = values.Item2;

                    if (symbol == '*')
                    {
                        currentResult = value1 * value2;
                    }

                    if (symbol == '/')
                    {
                        currentResult = value1 / value2;
                    }

                    equation = operationAux.UpdateEquation(equation, value1, value2, symbol, currentResult, i);

                    i = 0;
                }

                i++;
            }

            return equation.ToString();
        }

        public double SubtractionAndAdiction(string equation)
        {
            StringBuilder finalResult = new StringBuilder(equation);
            int i = 0;
            double currentResult = 0;
            string expression;

            while (i < equation.Length)
            {
                if (equation[i] == '-' || equation[i] == '+')
                {
                    char symbol = equation[i];
                    var values = findNumbers.FindValues(equation, i, symbol);

                    double value1 = values.Item1;
                    double value2 = values.Item2;

                    if (symbol == '-')
                    {
                        currentResult = value1 - value2;
                    }

                    if (symbol == '+')
                    {
                        currentResult = value1 + value2;
                    }

                    equation = operationAux.UpdateEquation(equation, value1, value2, symbol, currentResult, i);

                    i = 0;
                }
                i++;
            }
            return double.Parse(equation.ToString());
        }
    }
}