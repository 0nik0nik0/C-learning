/* Задача 66: Задайте значения M и N. Напишите программу, которая
 найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Please type integer N, press enter!");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Please type integer M, press enter!");
int M = int.Parse(Console.ReadLine());


int SumOfInterval(int NumN, int NumM)
{
    if (NumN == NumM) return NumM;
    return NumN += SumOfInterval(NumN + 1, NumM);
}

Console.WriteLine(SumOfInterval(N, M));