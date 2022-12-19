/*Напишите программу, которая принимает на вход число и проверяет,
 кратно ли оно одновременно 7 и 23.

14 -> нет 
46 -> нет 
161 -> да
*/
Console.Clear();
Console.Write("Hi! Whats your name? ");
string username = (Console.ReadLine());

Console.WriteLine(username + ", insert any number and will find if its add or even: ");
int Num1 = Convert.ToInt32(Console.ReadLine());

if (Num1%7 ==0 && Num1%23 == 0)
Console.WriteLine(username + ", Your are lucky! ");
else 
Console.WriteLine(username + ", Try again! ");
