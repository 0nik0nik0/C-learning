/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
 */
/* Console.Clear();
Console.Write("Напишите число (А):  ");
int sum = 0;
int a = int.Parse(Console.ReadLine());
for (int i = 1; i <=a; i++)
{
    sum += i;
}
Console.Write(sum); */


/* 
int Fx(int a)
{
    int all = 0;
    for (int x = 0; x <= a; x++)
    {
        all += x;
    }
    return all;
}
Console.WriteLine(Fx(5));
Console.WriteLine(Fx(7));

 */



void GetSumNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(number); i++)
    {
        sum += i;
    } 
    Console.WriteLine($"Cумма цифр от 1 до {Math.Abs(number)}: {sum}");

}

Console.Clear();

GetSumNums(-5);
GetSumNums(58);
GetSumNums(25);
GetSumNums(16);

Console.WriteLine("Введите число A");
int n = Convert.ToInt32(Console.ReadLine());
GetSumNums(n);

Console.WriteLine("Введите число A");
GetSumNums(Convert.ToInt32(Console.ReadLine()));
