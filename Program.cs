using System;
namespace ConsoleApp1 {
    class Program {
        static void PrintLine(string output) { Console.WriteLine(output); }
        static double InputDouble() {
            try { return double.Parse(Console.ReadLine()); }
            catch { PrintLine("Error. Try again."); return 0.0; }
        }
        static void Main(string[] args) {
            while (true) {
                char oper = Console.ReadLine()[0];
                if (oper == 'q') { break; }
                double a = InputDouble(), b = InputDouble(), ans = 0;
                switch (oper) {
                    case '+': ans = a + b;
                        break;
                    case '-': ans = a - b;
                        break;
                    case '*': ans = a * b;
                        break;
                    case '/': ans = a / b;
                        break;
                    case '%': ans = a % b;
                        break;
                    case '^': ans = Math.Pow(a, b);
                        break;
                    default: ans = 0;
                        PrintLine("Wrong operation.");
                        break;
                }
                PrintLine(a + " " + oper + " " + b + " = " + ans);
            }
        }
    }
}