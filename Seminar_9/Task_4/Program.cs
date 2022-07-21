// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

int DegreeNum(int A, int B)
{
    if (B == 0) return 1;
    return DegreeNum(A, B-1) * A;
}

Console.WriteLine(DegreeNum(A, B));