using System;
namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            while (true) {
                try {
                    char oper = Console.ReadLine()[0];
                    if (oper == 'q') { break; }
                    double a = double.Parse(Console.ReadLine()), b = double.Parse(Console.ReadLine()), ans = 0;
                    if (oper == '+') { ans = a + b; }
                    else if (oper == '-') { ans = a - b; }
                    else if (oper == '*') { ans = a * b; }
                    else if (oper == '/') { ans = a / b; }
                    else if (oper == '%') { ans = a % b; }
                    else if (oper == '^') { ans = Math.Pow(a, b); }
                    else { Console.WriteLine("Wrong operation. Try again."); }
                    Console.WriteLine(a + " " + oper + " " + b + " = " + ans);
                } catch { Console.WriteLine("Error. Try again."); }
            }
        }
    }
}