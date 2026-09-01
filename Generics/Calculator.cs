using System;
namespace Generics;

internal class Calculator
{


    static void Main(string[] args)
    {
        string exp = "(2*(2+3)+1)+1";

        List<char> operations = new List<char>() { '(', ')' };
        var expStartIndex = -1;
        var expEndIndex = -1;
        for (int i = 0; i < exp.Count(); i++)
        {
            if (exp[i] == '(')
            {
                expStartIndex = i;
            }
            if (exp[i] == ')')
            {
                expEndIndex = i;
                break;
            }
        }

        if (expStartIndex != -1)
        {
            var subExp = exp.Substring(expStartIndex, expEndIndex - expStartIndex);
            exp = exp.Replace($"({subExp})", $"{Calc(subExp)}");
        }


        double result = Calc(exp);

        Console.WriteLine($"{exp} = {result}");
        Console.ReadLine();
    }

    private static double Calc(string exp)
    {
        List<string> values = new List<string>();
        List<char> catchedOperators = new List<char>();
        List<char> operations = new List<char>() { '+', '*', '-', '/' };

        string currentNum = "";
        foreach (char c in exp)
        {
            if (!operations.Contains(c))
            {
                currentNum += c;
            }
            else
            {
                values.Add(currentNum);
                catchedOperators.Add(c);
                currentNum = "";
            }

        }
        if (!string.IsNullOrEmpty(currentNum))
        {
            values.Add(currentNum);
        }
        // calc * and /
        double result1 = double.Parse(values[0]);
        for (int i = 0; i < catchedOperators.Count; i++)
        {
            double left = double.Parse(values[i]);
            double right = double.Parse(values[i + 1]);

            if (catchedOperators[i] == '*' || catchedOperators[i] == '/')
            {
                if (catchedOperators[i] == '*')
                {
                    result1 = (left * right);
                    values[i] = result1.ToString();
                    values.RemoveAt(i + 1);
                    catchedOperators.RemoveAt(i);
                    i--;
                }
                else
                {
                    result1 = (left / right);
                    values[i] = result1.ToString();
                    values.RemoveAt(i + 1);
                    catchedOperators.RemoveAt(i);
                    i--;
                }

            }

        }


        // calc + and -
        double result = double.Parse(values[0]);

        for (int i = 0; i < catchedOperators.Count; i++)
        {
            double nextValue = double.Parse(values[i + 1]);
            if (catchedOperators[i] == '+')
            {
                result += nextValue;
            }
            if (catchedOperators[i] == '-')
            {
                result -= nextValue;
            }
        }

        //print the expression
        //for (int i = 0; i < values.Count; i++)
        //{
        //    Console.Write(values[i]);
        //    if (i < catchedOperators.Count)
        //    {
        //        Console.Write(catchedOperators[i]);
        //    }
        //}
        return result;
    }

    static double EnterNum(string messsage)
    {
        double num;
        do
        {
            Console.Write(messsage);

        } while (!double.TryParse(Console.ReadLine(), out num));
        return num;
    }
}
