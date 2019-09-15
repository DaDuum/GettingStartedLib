using System;
using System.ServiceModel;

namespace GettingStartedLib
{
    public class CalculatorService : ICalculator
    {
        public double Add(double number1, double number2)
        {

            double result = number1 + number2;
            Console.WriteLine("Received Add({0},{1})", number1, number2);
            Console.WriteLine("Return: {0}", result);
            return result;
        }
        public double Subtract(double number1, double number2)
        {
            double result = number1 - number2;
            Console.WriteLine("Received Subtract({0},{1})", number1, number2);
            Console.WriteLine("Return: {0}", result);
            return result;
        }
        public double Multiply(double number1, double number2)
        {
            double result = number1 * number2;
            Console.WriteLine("Received Multiply({0},{1})", number1, number2);
            Console.WriteLine("Return: {0}", result);
            return result;
        }

        public double Divide(double number1, double number2)
        {
            double result = number1 / number2;
            Console.WriteLine("Received Divide({0},{1})", number1, number2);
            Console.WriteLine("Return: {0}", result);
            return result;
        }
    }
}