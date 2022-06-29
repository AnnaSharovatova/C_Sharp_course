// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int X = 2;

while (N >= X)
{
    Console.WriteLine(X);
    X +=2;
}
