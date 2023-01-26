/* Задача 54: Задайте двумерный массив. Напишите программу,
 которая упорядочит по убыванию элементы каждой строки двумерного
  массива. */


int[,] array = GetArray(5, 5, 10, 20);
PrintArray(array);
Console.WriteLine();
PrintArray(ArrayStringReduction(array));
Console.WriteLine();
int[,] ArrayStringReduction(int[,] array)
{

    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int k = y + 1; k < array.GetLength(1); k++)
            {
                if (array[x, k] > array[x, y])
                {
                    int n = array[x, y];
                    array[x, y] = array[x, k];
                    array[x, k] = n;
                }
            }
        }
    }
    return array;
}
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[new Random().Next(5, 8), new Random().Next(5, 8)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}
