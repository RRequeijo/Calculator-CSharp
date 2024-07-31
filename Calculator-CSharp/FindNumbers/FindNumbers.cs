namespace Calculator_CSharp.FindNumbers
{
    public class FindNumbers : IFindNumbers
    {
        public (double, double) FindValues(string equation, int start, char symbol)
        {
            double value1 = 0;
            double value2 = 0;
            string value1String = string.Empty;
            string value2String = string.Empty;

            if (equation[start] == symbol)
            {
                for (int i = start - 1; i >= 0; i--)
                {
                    if (char.IsDigit(equation[i]) || equation[i] == '.')
                    {
                        value1String = equation[i] + value1String;
                        break;
                    }

                    break;
                }

                for (int i = start + 1; i < equation.Length; i++)
                {
                    if (char.IsDigit(equation[i]) || equation[i] == '.')
                    {
                        value2String += equation[i];
                    }

                    break;
                }

                value1 = double.Parse(value1String);
                value2 = double.Parse(value2String);
            }

            return (value1, value2);
        }
    }
}