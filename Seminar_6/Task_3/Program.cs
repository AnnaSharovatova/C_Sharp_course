// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void Binary(int number)
{
    string Dec = "";
    while (number > 0)
    {
        Dec = number % 2 + Dec;
        number /= 2;
    }
    Console.WriteLine(Dec);
}

Binary(45);


