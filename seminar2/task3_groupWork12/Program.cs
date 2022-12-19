/*Напишите программу, которая будет принимать на вход два числа
и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/


Console.Clear();
Console.WriteLine("Insert number A");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Insert number B");
int b = int.Parse(Console.ReadLine());

if(b%a==0)
{
Console.Write($"Number {b} multiple {a}");
}
else
{
Console.Write($"Число B некратно числу А, остаток от деления:{b%a}");
}
