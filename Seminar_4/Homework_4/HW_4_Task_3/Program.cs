﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Print(int[] arr)
{
int size = arr.Length;

for (int i = 0; i < size; i++)
{
Console.Write($"{arr[i]} ");
}
Console.WriteLine();
}

int[] ArrayOfEightNums()
{
    int size = 8;
    int[] arr = new int[size];

for (int i = 0; i < size; i++)
{
arr[i] = new Random().Next(1,100);
}
return arr;
}
int[] arr_1 = ArrayOfEightNums();
Print(arr_1);
