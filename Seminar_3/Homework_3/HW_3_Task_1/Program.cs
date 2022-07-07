// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrom(int number)
{
    int index = 0;
    string NUM = number.ToString();
    int size = NUM.Length - 1;
    string result = "Palindrom";

    while (index < size / 2)
    {
        if (NUM[index] != NUM[size - index])
        {
            result = "Not_a_Palindrom";
            break;
        }
        index += 1;
    }
    Console.WriteLine($"Число {number} -> {result}");
}

Palindrom(14212);
Palindrom(12821);
Palindrom(23432);