namespace Calculator_CSharp.Priority
{
    using Calculator_CSharp.FindNumbers;
    using System.Text;

    public class BasicOperations : IBasicOperations
    {
        public FindNumbers findNumbers = new FindNumbers();

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

                    i += values.Item2.ToString().Length;
                }
                else
                {
                    newEquation.Append(equation[i]);
                    i++;
                }
            }

            newEquation.Append(currentResult);

            return newEquation.ToString();
        }

        public double SubtractionAndAdiction(string equation)
        {
            double currentResult = 0;
            int i = 0;

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

                    i += values.Item2.ToString().Length;
                }
                else
                {
                    i++;
                }
            }

            return currentResult;
        }
    }
}