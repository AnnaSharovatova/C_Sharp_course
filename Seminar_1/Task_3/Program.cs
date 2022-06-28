// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Write("Введите порядковый номер дня недели: ");
int day = int.Parse(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine("Понедельник");
}
else if (day == 2)
{
    Console.WriteLine("Вторник");
}
else
{
    Console.WriteLine("Такого дня нет!");
}