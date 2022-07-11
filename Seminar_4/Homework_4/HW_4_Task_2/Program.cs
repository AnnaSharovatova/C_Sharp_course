// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumOfNum(int num)
{
    int sum_of_num = 0;
    while (num > 0)
    {
        sum_of_num += num % 10;
        num = num / 10;
    }
    return sum_of_num;
}
Console.WriteLine(SumOfNum(num));
