// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает последнюю цифру этого числа.

int TakeLastNum(int Num)
{
    return Num % 10; 
}

Console.WriteLine(TakeLastNum(766));
