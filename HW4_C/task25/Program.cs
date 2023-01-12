/* Задача 25: Напишите цикл, который принимает на
вход два числа (A и B) и возводит число A в \
натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


Console.Write("Insert 1st number: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Insert 2st number: ");
int B = int.Parse(Console.ReadLine());

int mult = 1;
for (int i = 1; i <= b; i++)
{
    mult *= a;
}
Console.Write(mult);
