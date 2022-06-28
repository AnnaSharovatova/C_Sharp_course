// Напишите программу, которая на вход принимает два числа 
// и проверяет, является ли первое число квадратом второго.

Console.Write("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine());

if (num_1 * num_1 == num_2 )
{
    Console.WriteLine($"Да, {num_1}^2 -> {num_2}");
}
else
Console.WriteLine("Нет");