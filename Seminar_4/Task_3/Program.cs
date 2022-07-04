// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int MultNum(int num)
{
    int all_mult = 1;
    for (int i = 1; i <= num; i++)
    {
        all_mult *= i;
    }
    return all_mult;
}
Console.WriteLine(MultNum(4));