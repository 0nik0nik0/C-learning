/* Демонстрация решения
Задача 39: Напишите программу, которая перевернёт 
одномерный массив (последний элемент будет на первом месте,
 а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
 */


 int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}


void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] array = CreateRandomArray(10, 0, 500);
ShowArray(array);
for (int i = 0; i < array.Length/2; i++)
{
    int temp = array[i];
    array[i] = array [array.Length - i - 1];
    array [array.Length - i - 1] = temp;
}

ShowArray(array);  
