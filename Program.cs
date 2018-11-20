using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// This is a Calculator with 4 operations:
    /// Addition, Subtraction, Multiplication and Division.
    /// The user enters 2 numbers (a and b) and the required operation.
    /// The program prints the output.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            InputData();
        }
        // Gets the inputs a, b and operation
        static void InputData()
        {
            double a, b;
            Console.Write("Operation: ");
            char oper = Console.ReadLine()[0];
            Console.Write("A = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("B = ");
            b = double.Parse(Console.ReadLine());
            Calc(a, b, oper);
        }
        // Returns the sum of a and b
        static double Add(double a, double b) { return a + b; }
        // Returns the difference of a and b
        static double Sub(double a, double b) { return a - b; }
        // Returns the product of a and b
        static double Mul(double a, double b) { return a * b; }
        // Returns the TODO of a and b
        static double Div(double a, double b) { return a / b; }
        // Prints the selected operation of a and b
        static void Calc(double a, double b, char oper)
        {
            double ans = 0;
            bool error = false;
            switch (oper)
            {
                case '+':
                    ans = Add(a, b);
                    break;
                case '-':
                    ans = Sub(a, b);
                    break;
                case '*':
                    ans = Mul(a, b);
                    break;
                case '/':
                    ans = Div(a, b);
                    break;
                default:
                    error = true;
                    Console.WriteLine("You entered a wrong operation. Try again.");
                    InputData();
                    break;
            }
            if (!error)
                Console.WriteLine(a + " " + oper + " " + b + " = " + ans);
                Console.Read();
        }
    }
}
