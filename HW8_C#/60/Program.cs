/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1).
 */

int[,,] array = GetArray(2, 2, 2, 10, 99);
PrintArray(array);

int[,,] GetArray(int row1, int row2, int row3, int min, int max)
{
    int[,,] result = new int[row1, row2, row3];
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < row2; j++)
        {
            for (int l = 0; l < row3; l++)
            {
                result[i, j, l] = new Random().Next(min, max + 1);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int l = 0; l < inArray.GetLength(2); l++)
            {
                Console.Write($"{inArray[i, j, l]}({i}, {j}, {l})\t");
            }
            Console.WriteLine();
        }
    }
}

