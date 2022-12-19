/*Напишите программу, которая принимает на вход два числа и проверяет,
 является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/


Console.Clear();
Console.WriteLine("Insert number A");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Insert number B");
int b = int.Parse(Console.ReadLine());

if(a==b*b)
Console.WriteLine("Число A является квадратом числа В");
else
Console.WriteLine("Число A НЕявляется квадратом числа В");
if(b==a*a)
Console.WriteLine("Число B является квадратом числа A");
else
Console.WriteLine("Число B НЕявляется квадратом числа A");