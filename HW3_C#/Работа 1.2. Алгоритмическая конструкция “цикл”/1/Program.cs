/* 1. Вычисляется сумма всех нечетных натуральных
 чисел от n1 до n2
(n1 и n2 вводятся с клавиатуры, цикл for). */


Console.Write("Введите целое число (n1) ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите целое число (n2) ");
int n2 = int.Parse(Console.ReadLine());

int sum = 0; 


for (int i = n1; i <= n2; i++)
{
    if (i % 2 != 0)
    {
    Console.WriteLine($"процесс {sum} + {i} = {sum + i}"); 
    sum = sum + i;
    }
}
Console.WriteLine("сумма всех нечетных натуральных чисел от n1 до n2   " + sum);
