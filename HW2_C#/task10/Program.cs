/*Задача 10: Напишите программу, которая принимает на вход трёхзначное
число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();
Console.WriteLine("Insert number A");
int num = int.Parse(Console.ReadLine());
if (num > 99 && num < 1000)
{
    int number = ((num % 100) / 10);
    Console.WriteLine($"{number} Good job!");
}
else
{
    Console.WriteLine("Incorrect number, try again!");
}
