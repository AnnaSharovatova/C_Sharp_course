// Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

void Coordinates(int quarter)
{  
    if (quarter == 1) Console.WriteLine("x > 0, y > 0");
    else if (quarter == 2) Console.WriteLine("x < 0, y > 0");
    else if (quarter == 3) Console.WriteLine("x < 0, y < 0");
    else if (quarter == 4) Console.WriteLine("x > 0, y < 0");
    else Console.WriteLine("Некорректно внесена четверть!");
}
Coordinates(1);
Coordinates(2);
Coordinates(3);
Coordinates(4);
Coordinates(5);