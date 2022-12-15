/*Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Clear();

Console.WriteLine("Insert number 1");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Insert number 2");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Insert number 3");
int c = int.Parse(Console.ReadLine());

int MaxNumber = a;
if (b > MaxNumber) 
    MaxNumber = b;
if (c > MaxNumber) 
    MaxNumber = c;
Console.WriteLine("max number = " +MaxNumber); 

    
Console.WriteLine("Good job!:)"); 
