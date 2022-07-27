// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Sequence(int num)
{
    if (num == 0) return;
    Sequence(num - 1);
    Console.Write($"{num}, ");
}
Sequence(num);