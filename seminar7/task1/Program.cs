/* // Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
 */

/* Задача 48: Задайте двумерный массив размера m на n,
 каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
  Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */

/* Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}
 */

/* Задача 49: Задайте двумерный массив. Найдите элементы,
 у которых оба индекса чётные, и замените эти элементы на
 их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4 */


Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
             result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
        
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[,] SquarePositivePlaces (int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0) {
                array[i,j]=array[i,j]*array[i,j];
            }
        }
    }
    return array;
}
Console.WriteLine("Измененный массив, где элементы с положительными индексами - квадрат: ");
SquarePositivePlaces (array);
PrintArray(array);

/* 
Задача 51: Задайте двумерный массив. Найдите сумму элементов,
 находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */

/* Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
             result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
        
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
int SquarePositivePlaces (int[,] inArray)
{
    int sum=0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i==j)
            {
                sum =sum + inArray[i,j];
            } 
        }
    }
    return sum;
}
Console.WriteLine($"Сумма элементов массива, стоящих на диагонали: {SquarePositivePlaces(array)}");

 */

/*  Console.WriteLine("\ny/x |   1\t2\t3\t4\t5\t6\t7\t8\t9");
            Console.Write("--------------------------------------------------------------------------");
            Console.WriteLine();
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i + "   |  ");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("\t"+i*j);
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
            Console.ReadLine(); */


/* using System;
 
namespace fifteenthMay
{
    class Program
    {
        public static void Main(string[] args)
        {
    
            
            int[,] arr= new int[10,10];
            int[] arr1 = {1,2,3,4,5,6,7,8,9};
            Console.Write("x/y |\t");
            for (int i = 0; i< arr1.Length;++i){
                Console.Write(  arr1[i]  +  "\t");
            }
            Console.WriteLine();
            Console.Write("---------------------------------------------------------------------");
            Console.WriteLine();
            
            for (int i = 1; i < arr.GetLength(0); ++i)
            {
                for (int j = 1; j < arr.GetLength(1); ++j)
                {   
                    
                    int sum = i * j;
                    if (i == j)
                    {
                        arr[i,j] = sum;
                        Console.Write(arr[i,j] + "\t");
                    }
                    else if (i > j)
                    {
                        arr[i,j] = sum;
                        Console.Write(arr[i,j] + "\t");
                    }
                    else if (i < j)
                    {
                        arr[i,j] = sum;
                        Console.Write(arr[i,j] + "\t");
                    }
                    
                }
                Console.WriteLine("\n\n");
            }
        
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
} */