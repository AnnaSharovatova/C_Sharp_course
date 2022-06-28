// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.

using System;

namespace _2_2
{
    class Program
    {
        static int CheckinValues(in int value1, in int value2)
        {
            return (value1 % value2);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первое число ");
            int value1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число ");
            int value2 = int.Parse(Console.ReadLine());

            int Result = CheckinValues(in value1, in value2);

            if (Result == 0)
            {
                Console.WriteLine("Числа кратные");
            }
            else
            {
                Console.WriteLine($"Остаток от деления {Result}");
            }
        }
    }
}
