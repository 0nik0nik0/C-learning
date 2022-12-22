/* Задача №17. Напишите программу, которая принимает на вход 
координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в 
которой находится эта точка. */

void PrintCord(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("piont is in 1st quarter");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("piont is in 2nd quarter");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("piont is in 3rd quarter");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("piont is in 4th quarter");
    }
    else
    {
        Console.WriteLine("imposiible to detemine the quarter");
    }
}

Console.WriteLine("Insert coordinate X");
int cordX = int.Parse(Console.ReadLine());
Console.WriteLine("Insert coordinate Y");
int cordY = int.Parse(Console.ReadLine());
PrintCord(cordX, cordY);
PrintCord(10,214);
PrintCord(50,22);
// Console.WriteLine(returnQuarter(x,y));
// int quarter = returnQuarter(x,y);
// Console.WriteLine($"Четверть: {quarter}");




/* Console.Clear();
Console.WriteLine("Insert coordinate X");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Insert coordinate Y");
int y = int.Parse(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine ("piont is in 1st quarter");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine ("piont is in 2nd quarter");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine ("piont is in 3rd quarter");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine ("piont is in 4th quarter");
}
else
{
    Console.WriteLine ("imposiible to detemine the quarter");
}
 */


/* Console.WriteLine("Введите любое число по оси X");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любое число по оси Y");
int Y = Convert.ToInt32(Console.ReadLine());
if(X < 0)
{
    if(Y < 0)
    {
        Console.WriteLine("Точка находится в 1 четверте");
    }
    else
    {
        Console.WriteLine("Точка находится в 2 четверте");
    }
}
else
{
    if(Y < 0)
    {
        Console.WriteLine("Точка находится в 3 четверте");
    }
    else
    {
        Console.WriteLine("Точка находится в 4 четверте");
    }
}
 */