/* 2. Вычисляется сумма квадратов n натуральных чисел,
 начиная с k
(вводятся k и n, цикл for).
 */


Console.Write("Введите целое число (k) ");
int k = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во натуральных чисел (n) ");
int n = int.Parse(Console.ReadLine());

int sum = 0; 

for (int i = k; i < k+n; i++) 
{
sum = sum + i*i;
}
 Console.WriteLine("сумма квадратов n натуральных чисел, начиная с k   " + sum);