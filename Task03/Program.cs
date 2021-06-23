using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stayInProcess = true;

            while (stayInProcess)
            {
                Console.WriteLine("Задайте число от 0 до 100:");
                int a = Convert.ToInt32(Console.ReadLine());

                while (a < 0 || a > 100)
                {
                    Console.WriteLine("Число задано вне диапазона поиска. Повторите ввод");
                    a = Convert.ToInt32(Console.ReadLine());
                }

                if (a >= 0 && a <= 14) Console.WriteLine("-Число находится в промежутке [0-14]");
                if (a >= 15 && a <= 35) Console.WriteLine("-Число находится в промежутке [15-35]");
                if (a >= 36 && a <= 50) Console.WriteLine("-Число находится в промежутке [36-50]");
                if (a >= 50 && a <= 100) Console.WriteLine("-Число находится в промежутке [50-100]");

                Console.WriteLine(new string('-', Console.WindowWidth));

                Console.WriteLine("Повторить действие? (да/нет)");

                stayInProcess = Console.ReadLine() == "да" ? true : false;

                Console.Clear();
            }
        }
    }
}
