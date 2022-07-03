// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите порядковый номер дня недели: ");
int DayNum = int.Parse(Console.ReadLine());

if (DayNum == 6 || DayNum ==7)
{
    Console.WriteLine("Ура, выходной!");
}
else if (DayNum >=1 && DayNum <= 5)
{
    Console.WriteLine("Будний день! Надо еще потрудиться!");
}
else 
{
    Console.WriteLine("Друг, в неделе всего 7 дней!");
}
