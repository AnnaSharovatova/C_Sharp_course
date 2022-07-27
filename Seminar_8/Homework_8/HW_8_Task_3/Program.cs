// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

int [,] SquareMatrixProduct(int[,]arr_first, int[,]arr_second)
{
    int row = arr_first.GetLength(0);
    int column = arr_first.GetLength(1);
    int[,] Multiplied_arr = new int[row, column];

    if(row != arr_second.GetLength(0) || column != arr_second.GetLength(1) ) return Multiplied_arr;

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            Multiplied_arr[i, j] = arr_first[i, j]*arr_second[i,j];
        return Multiplied_arr;
}

Console.WriteLine("Введите число рядов первого массива: ");
int row_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число колонок первого массива: ");
int column_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число рядов второго массива: ");
int row_2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число колонок второго массива: ");
int column_2 = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] arr_1 = MassNums(row_1, column_1, 1, 101);
Print(arr_1);

int[,] arr_2 = MassNums(row_2, column_2, 1, 101);
Print(arr_2);

Console.WriteLine();

int[,] Multiplied_arr = SquareMatrixProduct(arr_1, arr_2);
Print(Multiplied_arr);