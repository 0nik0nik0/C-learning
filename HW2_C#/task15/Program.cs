/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();

string[] week = { "mon", "tue", "wed", "thu", "fri", "sat", "sun" };

Console.WriteLine("Enter the day of the week");
int num = int.Parse(Console.ReadLine());

if (num > 7 || num <= 0)
{
    Console.WriteLine("Please think before typing");
}
else if (num > 5)
{
    Console.WriteLine($"Today its {week[num - 1]}, take a rest!");
}
else
{
    Console.WriteLine($"Today its {week[num - 1]}, be strong!");
}
