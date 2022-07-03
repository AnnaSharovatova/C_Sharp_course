// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int Num = int.Parse(Console.ReadLine());

int TakeSecondNum(int Num)
{
    return Num / 10 % 10;
}

Console.WriteLine(TakeSecondNum(Num));