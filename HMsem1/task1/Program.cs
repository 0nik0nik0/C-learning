/*Задача 2: Напишите программу, которая на вход принимает 
два числа и выдает, какое число большее, а какое меньшее.
a = 5; b = 7 ->  max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/


Console.Clear();

Console.WriteLine("Insert number 1");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Insert number 2");
int b = int.Parse(Console.ReadLine());

if(a>b)
{
    Console.WriteLine($"Max number = {a} , Max number = {b} ");

}
else
{
    Console.WriteLine($"Max number = {b} , Max number = {a} ");

}

