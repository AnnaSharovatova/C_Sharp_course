// // Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumOfNumsInSequence(int M, int N)
{
    if (N < M) return 0;
    return SumOfNumsInSequence(M, N - 1) + N;
}
Console.WriteLine($"Сумма чисел в заданной последовательности = {SumOfNumsInSequence(M, N)}");