/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
 находить произведение двух матриц. */

int[,] matrix1 = GetArray(2, 2, 0, 10);
int[,] matrix2 = GetArray(2, 2, 0, 10);

Console.WriteLine("Created matrix #1");
PrintArray(matrix1);
Console.WriteLine("Created matrix #2");
PrintArray(matrix2);

int[,] resultMatrix = MultiplyMatrix(matrix1, matrix2);
Console.WriteLine("\nResult of multiplying 2 matrix:");
PrintArray(resultMatrix);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
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

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(0); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < result.GetLength(0); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}

