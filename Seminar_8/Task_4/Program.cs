﻿// Задача 4: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7



int[,] ModMass (int[,] arr)
{
    int count = 0;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    while (count <= row*column)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column-1; j++)
            {
                if (arr[i,j] < arr[i,j+1]) 
                {
                    (arr[i,j], arr[i,j+1]) = (arr[i,j+1], arr[i,j]);
                }
            }
        }
        count++;
    }
    return arr;
}