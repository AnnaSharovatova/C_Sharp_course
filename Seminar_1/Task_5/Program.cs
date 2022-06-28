// Напишите программу, которая на вход принимает одно число(N), 
// а на выходе показывает все числа в промежутке от -N до N

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int negative_num = -num;

while (num +1 > negative_num)
{
    Console.WriteLine(negative_num);
    negative_num ++;
}