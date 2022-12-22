/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Clear();
Console.WriteLine("Insert positive number");
int num = int.Parse(Console.ReadLine());
if (num < 0)
    {
    Console.WriteLine("Number should be positive(+), please try again!");
    }
else if (num < 100)
    {
    Console.WriteLine("no 3rd sign, try again!");
    }
else
{
     while (num > 1000)
    {
        num = num/10;
    }
    Console.WriteLine($"{num % 10} Good job!");  
}