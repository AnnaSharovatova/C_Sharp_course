// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-999, 1000) + new Random().NextDouble();
    }
    return arr;
}
double DiffMaxMin(double[] arr)
{
    double max_num = arr[0];
    double min_num = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max_num < arr[i])
        {
            max_num = arr[i];
        }
        if (min_num > arr[i])
        {
            min_num = arr[i];
        }
    }
    double decision = max_num - min_num;
    Console.WriteLine(max_num);
    Console.WriteLine(min_num);
    return decision;
}
double[] arr_1 = MassNums(8);
Print(arr_1);
Console.WriteLine(DiffMaxMin(arr_1));