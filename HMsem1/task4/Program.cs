// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Hi! Whats your name? ");
string username = (Console.ReadLine());

Console.WriteLine(username + ", enter any number and we will show all even numbers it stores in itself: ");
int Num1 = Convert.ToInt32(Console.ReadLine());

int i = 0;

while (i < Num1)
{
    i += 2;
    Console.WriteLine(i);
}

Console.WriteLine(username + ", here you are! ");
