//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:

// 3 10 7 3
// 1 5 9 3
// 8 4 7 0
// 7 1 9 3

// В итоге получается вот такой массив:

// 10 7 3 3
// 9 5 3 1
// 8 7 4 0
// 9 7 3 1

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

int[,] SortArrayFromMaxToMinElements (int[,] arr)
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

Console.WriteLine("Введите число рядов: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число колонок: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] arr_1 = MassNums(row, column, 1, 101);
Print(arr_1);

SortArrayFromMaxToMinElements(arr_1);
Print(arr_1);