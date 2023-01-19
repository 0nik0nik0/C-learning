/*  Задача 38: Задайте массив вещественных чисел. 
 Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */


double[] CreateRandomArray(int N, int start, int end)
{
    double[] RandomArray = new double[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1) + new Random().NextDouble();
        if (RandomArray[i] > end) RandomArray[i] = end;
    }
    return RandomArray;
}
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double ArraysMin(double[] array)

{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double ArraysMax(double[] array)

{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double[] array = CreateRandomArray(6, 100, 1000);
Console.WriteLine($"Difference between maximal and minimal numbers in your array is: {ArraysMax(array)}-{ArraysMin(array)} = {ArraysMax(array) - ArraysMin(array)} ");

/* 
double max = ArraysMax(array);
double min = ArraysMin(array);
Console.WriteLine($"Difference between maximal and minimal numbers in your array is: {max}-{min} = {max- min} "); */


Console.Write($"Your array:{String.Join("| ", array)} ");
/* Console.Write("Your array: ");
ShowArray(array); */

//string.Format("{0:f4}", number   -  ограничение знаков после запятой