/* Задача 62: Заполните спирально массив 4 на 4. */

int rows = 4, columns = 4;
int[,] myArr = new int[rows, columns];
FillArray(myArr, 1, 0, 0);

PrintArray(myArr);
void FillArray(int[,] table, int number, int row, int column, int direction = 0)
/*  0 - go right
    1 - go down
    2 - go left
    3 - go up */
{
    if (table[row, column] != 0) return;
    table[row, column] = number;
    if (direction == 0)
    {
        if (column + 1 < table.GetLength(1) && table[row, column + 1] == 0) FillArray(table, number + 1, row, column + 1, direction);
        else FillArray(table, number + 1, row + 1, column, 1);
    }
    if (direction == 1)
    {
        if (row + 1 < table.GetLength(0) && table[row + 1, column] == 0) FillArray(table, number + 1, row + 1, column, direction);
        else FillArray(table, number + 1, row, column - 1, 2);
    }
    if (direction == 2)
    {
        if (column - 1 >= 0 && table[row, column - 1] == 0) FillArray(table, number + 1, row, column - 1, direction);
        else FillArray(table, number + 1, row - 1, column, 3);
    }
    if (direction == 3)
    {
        if (row - 1 >= 0 && table[row - 1, column] == 0) FillArray(table, number + 1, row - 1, column, direction);
        else FillArray(table, number + 1, row, column + 1, 0);
    }
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

