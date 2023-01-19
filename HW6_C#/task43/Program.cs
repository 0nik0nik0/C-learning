/* Задача 43: Напишите программу, которая найдёт точку пересечения
 двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
  значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


Console.Write("Equation for calculating the intersection points of two straight lines:\ny = k1 * x + b1\ny = k2 * x + b2\n\n\n");
Console.WriteLine("Enter the slope angle coefficient k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter value b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the slope angle coefficient k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter value b2: ");
double b2 = double.Parse(Console.ReadLine());
return;

if (k1 != k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    /* double y1 = k2 * x + b2;
    if (y1 == y) */
    Console.Write($"Congrtulations! Your lines intersect. \nСoordinates of the intersection point of two straight lines \nx = {x} y = {y}");
}
else if (k1 == k2 && b1 != b2)
{
    Console.Write("Two straight lines are parallel, ==> they will never intersect and the system will have no solutions");

}
else if (k1 == k2 && b1 == b2)
{
    Console.Write("Two straight lines have coincided ==> each point will be a solution ==> the system will have countless solutions.");
}
