using System;

namespace SimpleCalculator
{
    public class Calculator2
    {
        public static class _Calculator
        {
            public static string Calculator(int operand1, int operand2, string operation)
            {
                return operation switch
                {
                    "+" => $"{operand1} {operation} {operand2} = {operand1 + operand2}",
                    "*" => $"{operand1} {operation} {operand2} = {operand1 * operand2}",
                    "/" when operand2 == 0 => "Division by zero is not allowed.",
                    "/" => $"{operand1} {operation} {operand2} = {operand1 / operand2}",
                    null => throw new ArgumentNullException(),
                    "" => throw new ArgumentException(),
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
        }


    }
}
