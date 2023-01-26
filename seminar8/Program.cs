/* Задача 53: Задайте двумерный массив. Напишите программу,
 которая поменяет местами первую и последнюю строку массива. */


/* Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}
Console.WriteLine();

int[,] SwapArray(int[,] array)
{
    int n;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        n = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0)-1,i] = n;
    }
    return array;
}
SwapArray(array);
PrintArray(array); */

/* Задача 55: Задайте двумерный массив. Напишите программу,
 которая заменяет строки на столбцы. В случае, если это невозможно,
  программа должна вывести сообщение для пользователя. */

/* 
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
if (rows == columns) 
{   
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int [,] newarray = ReversRowColArray2D(array);
PrintArray(newarray);
}
else
{
    Console.WriteLine("кол-во строк не равно кол-во стобцов");
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

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

int[,] ReversRowColArray2D(int[,] arr)
{
    int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newArr[j, i] = arr[i, j];
        }
    }
    return newArr;
} */

/* Задача 57: Составить частотный словарь элементов двумерного массива.
 Частотный словарь содержит информацию о том, сколько раз встречается
  элемент входных данных.
 */


/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
 которая удалит строку и столбец, на пересечении которых расположен
  наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7 */


/* Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод
 в виде равнобедренного треугольника */

/*  Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника */



/* Console.Write("Введите количество строк : ");
int n = int.Parse(Console.ReadLine());


int[][] triangle = new int[n][];
// первая строка
triangle[0] = new int[] { 1 };

for (int i = 1; i < triangle.Length; i++)
{
    triangle[i] = new int[i + 1];
    for (int j = 0; j <= i; j++)
    {
        if (j == 0 || j == i)
            triangle[i][j] = 1;
        else
        {
            triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
        }
    }
}

for (int i = 0; i < triangle.Length; i++)
{
    for (int j = 0; j < triangle[i].Length; j++)
    {
        Console.Write("{0,-3} ", triangle[i][j]);
    }
    Console.WriteLine();
 }*/


/* Console.Write("Size of Matrix: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] pascal = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if (i == j || j == 0)
        {
            pascal[i, j] = 1;
        }
        else if (j > i)
        {
            pascal[i, j] = 0;
        }
        else if (i != j)
        {
            pascal[i, j] = pascal[i - 1, j - 1] + pascal[i - 1, j];
        }
        
        Console.Write($"{pascal[i, j],5 }");
    }
    Console.WriteLine();
}
 */