using System;

namespace Make_a_function_that_does_arithmetic
{
    /// <summary>
    /// Given two numbers and an arithmetic operator (the name of it, as a string), return the result of the two numbers having that operator used on them. 
    /// a and b will both be positive integers, and a will always be the first number in the operation, and b always the second.
    /// The four operators are "add", "subtract", "divide", "multiply". 
    /// </summary>
    public class Kata
    {
        public static double Arithmetic(double a, double b, string op)
        {

            Operations operations = EnumOperations(op);
            switch (operations)
            {
                case Operations.Add:
                    return a + b;
                case Operations.Subtract:
                    return a - b;
                case Operations.Multiply:
                    return a *b;
                case Operations.Divide:
                    if (b != 0)
                    {
                        return a / b;
                    }
                    else throw new Exception("Math Error");
                default:
                    throw new Exception("Unknown operation");
            }
        }

        public static Operations EnumOperations(string operation)
        {
            switch (operation)
            {
                case "add":
                    return Operations.Add;
                case "subtract":
                    return Operations.Subtract;
                case "multiply":
                    return Operations.Multiply;
                case "divide":
                    return Operations.Divide;
                default:
                    return Operations.UnknownOperation;
            }
            
        }

    }

}
