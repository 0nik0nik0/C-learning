/* Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
 */

void SortNumbers()
{
    Console.Clear();
    Console.WriteLine("To stop the program, press 'q'.\nType as much integers as you wish (each time press 'Enter' after typing): ");
    bool GoCode = true;
    int result = 0;
    while (GoCode)
    {
        string m = Console.ReadLine();
        if (int.TryParse(m, out int n) && Convert.ToInt32(m) > 0)
        {
            result++;
        }
        else if (m == "q")
        {
            Console.Write($"You pressed 'q' => program stopped. \nNow we are going to calculate how many of your numbers are above 0 \nEntered {result} values above zero.\n");
            GoCode = false;
        }
    }
}
SortNumbers();

