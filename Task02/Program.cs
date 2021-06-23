using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                Console.WriteLine("available operations - +,-,*,/,^,\'");
                Console.WriteLine("Введите первое число: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                double a = Convert.ToDouble(Console.ReadLine());
                Console.ResetColor();
                Console.WriteLine("Задайте операцию:");
                Console.ForegroundColor = ConsoleColor.Red;
                string sign = Console.ReadLine();
                Console.ResetColor();
                Console.WriteLine("Введите второе число:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                double b = Convert.ToDouble(Console.ReadLine());
                Console.ResetColor();

                switch (sign)
                {
                    case "+":                        
                        Add(a, b);
                        break;
                    case "-":                        
                        Subtract(a, b);
                        break;
                    case "*":
                        Multiply(a, b);
                        break;
                    case "/":
                        Divide(a, b);
                        break;
                    case "%":
                        GetReminder(a, b);
                        break;
                    case "^":
                        RaiseToPower(a, b);
                        break;
                    case "\'":
                        GetRoot(a, b);
                        break;
                    default:
                        Console.WriteLine("Такое действие не предусмотрено программой");
                        break;
                }

                Console.WriteLine("Совершить ещё одно действие с числами? (y/n) ");

                string choice = Console.ReadLine();

                Console.Clear();

                if (choice == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }            
        }

        public static double Add(double a, double b)
        {
            double c = a + b;
            Console.WriteLine($"{a}+{b}={c}");
            return c;
        }

        public static double Subtract(double a, double b)
        {
            double c = a - b;
            Console.WriteLine($"{a}-{b}={c}");
            return c;
        }

        public static double Multiply(double a, double b)
        {
            double c = a * b;
            Console.WriteLine($"{a}*{b}={c}");
            return c;
        }

        public static double Divide(double a, double b)
        {
            double c = a / b;
            Console.WriteLine($"{a}/{b}={c}");
            return c;
        }

        public static double GetReminder(double a, double b)
        {
            double c = a % b;
            Console.WriteLine($"{a}%{b}={c}");
            return c;
        }

        public static double RaiseToPower(double number, double power)
        {
            double c = Math.Pow(number, power);
            Console.WriteLine($"{number}^{power}={c}");
            return c;
        }

        public static double GetRoot(double number, double rootGrade)
        {
            double c = Math.Pow(number, 1.0 / rootGrade);
            Console.WriteLine($"Корень {rootGrade} степени из {number} = {c}");
            return c;
        }
    }
}
