/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

 */

Console.Clear();
Console.Write("Insert number (А):  ");
int sum = 0;
int a = int.Parse(Console.ReadLine());

    while(a != 0)
    { 
        sum += a%10;
        a/=10;
    }
Console.Write($"Sum of digits in your number: {sum}");
