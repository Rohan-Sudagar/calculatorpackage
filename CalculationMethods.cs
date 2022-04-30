using System;

namespace CalculatorPackage
{
    public class CalculationMethods
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static double Divide(double x, double y)
        {
            return x / y;
        }
        public static double Percent(double x, double y)
        {
            return x * y / 100;
        }

        public static double Square(double x)
        {
            return x * x;
        }

        public static double SquareRoot(double x)
        {
            return x / 2;
        }
    }
}
