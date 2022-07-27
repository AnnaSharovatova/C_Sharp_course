// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumOfDigits(int num)
{
    if (num == 0) return 0;
    return SumOfDigits(num / 10) + num % 10;
}

Console.WriteLine(SumOfDigits(num));