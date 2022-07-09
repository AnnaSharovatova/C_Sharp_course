// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void Print(int[] arr)
{
int size = arr.Length;

for (int i = 0; i < size; i++)
{
Console.Write($"{arr[i]} ");
}
Console.WriteLine();
}

int[] MassNums(int size)
{
int[] arr = new int[size];

for (int i = 0; i < size; i++)
{
arr[i] = new Random().Next(1, 100);
}
return arr;
}

int SumOddIndexNum(int[]arr)
{
    int sum_odd = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i%2==1)
        {
            sum_odd+=arr[i];
        }
    }
    return sum_odd;
}
int[] arr_1 = MassNums(6);
Print(arr_1);
Console.WriteLine(SumOddIndexNum(arr_1));
