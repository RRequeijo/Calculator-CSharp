namespace Calculator_CSharp.BasicOperations
{
    public class BasicOperations : IBasicOperations
    {
        public double DivisionAndMultiplication(string equation)
        {
            int i = 0;
            string valueAfter = string.Empty;
            string valueBefore = string.Empty;
            double result = 0;
            while (i < equation.Length)
            {
                if (equation[i] == '/')
                {
                    i++;
                    while (i < equation.Length)
                    {
                        if (equation[i] == '*' || equation[i] == '/' || equation[i] == '-' || equation[i] == '+')
                        {
                            break;
                        }
                        valueBefore = equation[i] + valueBefore;
                        i++;
                    }

                    int j = i - 1;
                    while (j >= 0)
                    {
                        if (equation[j] == '*' || equation[j] == '/' || equation[j] == '-' || equation[j] == '+')
                        {
                            break;
                        }
                        valueBefore = equation[i] + valueBefore;
                        j--;
                    }
                    double after = Convert.ToDouble(valueAfter);
                    double before = Convert.ToDouble(valueBefore);

                    result = before / after;
                    break;
                }

                if (equation[i] == '*')
                {
                    i++;
                    while (i < equation.Length)
                    {
                        if (equation[i] == '*' || equation[i] == '/' || equation[i] == '-' || equation[i] == '+')
                        {
                            break;
                        }
                        valueAfter = equation[i] + valueAfter;
                        i++;
                    }
                    while (i < equation.Length)
                    {
                        if (equation[i] == '*' || equation[i] == '/' || equation[i] == '-' || equation[i] == '+')
                        {
                            break;
                        }
                        valueAfter = equation[i] + valueAfter;
                        i++;
                    }
                    double after = Convert.ToDouble(valueAfter);
                    double before = Convert.ToDouble(valueBefore);

                    result = before * after;
                    break;
                }
                i++;
            }
            return result;
        }
    }
}