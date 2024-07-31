namespace Calculator_CSharp.Priority
{
    using Calculator_CSharp.FindNumbers;
    using System.Text;

    public class BasicOperations : IBasicOperations
    {
        public FindNumbers findNumbers = new FindNumbers();

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

                    string value1String = value1.ToString();
                    string value2String = value2.ToString();
                    string symbolString = symbol.ToString();
                    string currentResultString = currentResult.ToString();

                    equation = equation.Replace($"{value1String}{symbolString}{value2String}", $"{currentResultString}");

                    newEquation = new StringBuilder(equation);

                    i = 0;
                }

                i++;
            }

            return newEquation.ToString();
        }

        public double SubtractionAndAdiction(string equation)
        {
            StringBuilder finalResult = new StringBuilder(equation);
            int i = 0;
            double currentResult = 0;

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

                    string value1String = value1.ToString();
                    string value2String = value2.ToString();
                    string symbolString = symbol.ToString();
                    string currentResultString = currentResult.ToString();

                    equation = equation.Replace($"{value1String}{symbolString}{value2String}", $"{currentResultString}");

                    finalResult = new StringBuilder(equation);

                    i = 0;
                }
                i++;
            }

            return double.Parse(finalResult.ToString());
        }
    }
}