// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Hi! Whats your name? ");
string username = (Console.ReadLine());

Console.WriteLine(username + ", insert any number and will find if its add or even: ");
int Num1 = Convert.ToInt32(Console.ReadLine());

if (Num1%2 == 0)
Console.WriteLine(username + ", Your number is even! ");

else
Console.WriteLine(username + ", Your number is odd!");
