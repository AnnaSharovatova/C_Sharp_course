// Напишите программу, которая будет создавать
// копию заданного двумерного массива с помощью поэлементного
// копирования. 

void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
    return arr;
}

int[,] CopyOriginalArray(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[,] newArr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newArr[i, j] = arr[i, j];
        }
    }
    return newArr;
}

int[,] arr = new int [3,5];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
int[,] newArr = CopyOriginalArray(arr);
PrintArray(newArr);