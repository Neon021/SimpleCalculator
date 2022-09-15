using System;

namespace SimpleCalculator
{
    public class Calculator1
    {
        public static class _Calculator
        {
            public class Operators
            {

                public void Addition(int x, int y)
                {
                    int z = x + y;
                    Console.WriteLine(z);
                }

                public void Multiplication(int x, int y)
                {
                    int z = x * y;
                    Console.WriteLine(z);
                }

                public void Division(int x, int y)
                {
                    decimal z = x / y;
                    Console.WriteLine(z);
                }
            }

            public class SimpleCalculator
            {
                public void Calculate(int x, int y, string op)
                {
                    Operators p = new Operators();

                    if (op == "Addition")
                    {
                        p.Addition(x, y);
                    }
                    else if (op == "Multiplication")
                    {
                        p.Multiplication(x, y);
                    }
                    else if (op == "Division")
                    {
                        if (x == 0)
                        {
                            try { }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("You can't divide by zero");
                            }
                        }
                        else
                            p.Division(x, y);
                    }
                    else if (op == null || op == "" || op == "Subtraction")
                    {
                        Console.WriteLine("Check the operator");
                    }
                }
            }
        }
    }
}
