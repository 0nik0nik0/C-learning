/* Задача 19

Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */


Console.Clear();

Console.Write("Enter a 5 digit number: ");
string number = Console.ReadLine();

if (number.Length != 5)
{
    Console.WriteLine($"Number incorrect");
} 
else if (number[0]==number[4] && number[1]==number[3])
  {
    Console.WriteLine($"Entered number: {number} - palindrome.");
  }
else 
  {
    Console.WriteLine($"Entered number: {number} - !not! a palindrome.");
  }

  /* Так же можно проверить не только цифры но 
  и слова (прим."казак", "мадам" и тд.) */



/* Альтернативный вариант для любой длины числа
Console.Clear();

Console.Write("Type any number or word");
string num = Console.ReadLine();
int numTxt = num.Length;

for (int i = 1; i < numTxt; i++)
{
    if (num[i - 1] != num[numTxt - (i)])
    {
        Console.WriteLine("!not! a palindrome");
        break;
    }
    if (i == numTxt-1)
    {
        Console.WriteLine("palindrome!");
        break;
    }
}
*/