/* Задача 64: Задайте значение N. Напишите программу, которая выведет
 все натуральные числа в промежутке от N до 1. Выполнить с помощью
  рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */


Console.WriteLine("Please type integer N, press enter!");
int N = int.Parse(Console.ReadLine());
PrintNto1(N);
void PrintNto1(int number)
{
    if (number < 1)
    {
        Console.Write("Incorrect number");
        return;
    }
    Console.Write($"{number}\t ");
    if (number == 1) return;
    else PrintNto1(number - 1);
}


