﻿// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

void TakeTwoNumbers()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine($"{num}->{num / 100}{num % 10}");
}
TakeTwoNumbers();