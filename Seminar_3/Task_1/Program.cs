// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X не = 0 или Y не равно 0 и выдает номер четверти плоскости, в которой находится эта точка.

void Quarters(int x, int y)
{
    if (x == 0 || y == 0) Console.WriteLine("x = 0, y = 0");
    else if (x > 0 & y > 0) Console.WriteLine("Quarter 1");
    else if (x < 0 & y > 0) Console.WriteLine("Quarter 2");
    else if (x < 0 & y < 0) Console.WriteLine("Quarter 3");
    else if (x > 0 & y < 0) Console.WriteLine("Quarter 4");
}
Quarters(0, 0);
Quarters(2, 3);
Quarters(-3, 4);
Quarters(-5, -2);
Quarters(2, -1);