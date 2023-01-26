
int[,] array = GetArray(3, 4, 10, 20);

Console.WriteLine("Your array is:");
PrintArray(array);
Console.WriteLine($"№ of row with minimal sum of values in it: {MinSumValuesRowNumber(array)+1}");


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

int RowValuesSum(int[,] array, int row)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        result += array[row, i];
    }
    return result;
}

int MinSumValuesRowNumber(int[,] array)
{
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (RowValuesSum(array, i) < RowValuesSum(array, min)) min = i;
    }
    return min;
}


