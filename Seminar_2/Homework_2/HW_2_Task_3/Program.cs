// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

    int SomeNumber = new Random().Next(1, 1000000);
    string SomeNumberText = Convert.ToString(SomeNumber);
    Console.WriteLine(SomeNumberText);

if (SomeNumberText.Length > 2)
{
    Console.WriteLine("Третья цифра числа -> " + SomeNumberText[2]);
}
else
{
    Console.WriteLine("Число меньше, чем трехзначное, а значит третьей цифры нет.");
}