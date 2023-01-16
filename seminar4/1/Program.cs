/* Задача 28: Напишите программу, которая принимает 
на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120 */

Console.Clear();
Console.Write("Напишите число (N):  ");
int sum = 1;
int a = int.Parse(Console.ReadLine());
for (int i = 1; i <=a; i++)
{
    sum *= i;
}
Console.Write(sum);

