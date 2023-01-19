//Задача 40. Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

/* Console.WriteLine("Введите первое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number < number2 + number3)
{
    if (number2 < number + number3)
    {
        if (number3 < number2 + number)
        {
            Console.WriteLine("Да, такой треугольник может существовать");
        }
        else
        {
            Console.WriteLine("Нет, такой треугольник не может существовать");
        }
    }
    else
    {
        Console.WriteLine("Нет, такой треугольник не может существовать");
    }
}
else
{
    Console.WriteLine("Нет, такой треугольник не может существовать");
} */



/* Console.WriteLine("Введите первое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number < number2 + number3)
{
    if (number2 < number + number3)
    {
        if (number3 < number2 + number)
        {
            Console.WriteLine("Да, такой треугольник может существовать");
        }
        else
        {
            Console.WriteLine("Нет, такой треугольник не может существовать");
        }
    }
    else
    {
        Console.WriteLine("Нет, такой треугольник не может существовать");
    }
}
else
{
    Console.WriteLine("Нет, такой треугольник не может существовать");
} */













/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */

/* Console.WriteLine("Введите число");
int number_10 = int.Parse(Console.ReadLine());  //10
int i = number_10;
string number_02 = "";
while (i > 0)
{
    number_02 = i % 2 + number_02;  //остаток от деления
    i = i / 2;                      //деление самого числа
}
Console.WriteLine(number_02);
//10 = 2+2+2+2+2(0)    (0)  ^
//5 = 2+2+(1)          (1)  |
//2 = 2(0)             (0)  |
//1 = 0(1)             (1)  |

 */



/* Console.Clear();

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int N = Convert.ToInt32(Console.ReadLine());
int[] Array = CreateRandomArray(Convert.ToInt32(Math.Log2(N))+1, 0, 1);
int i = 0;
while (N > 0)
{
    Array[Array.Length-i-1] = N % 2;
    N = N/2;
    i++;
}
ShowArray(Array); */ 




/* void DecimalBinary(int numb)
{
    string residue = string.Empty;
    while (numb > 0)
    {
        residue = Convert.ToString(numb % 2) + residue;
        numb /= 2;
        Console.WriteLine(numb);
    }
    Console.WriteLine(residue);
}

DecimalBinary(14);
 */










/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

/* Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 0;
int number2 = 1;
int number3 = 0;
int j = 0;
Console.WriteLine(number1);
Console.WriteLine(number2);
while(j < number)
{
    number3 = number1 + number2;
    Console.WriteLine(number3);
    number1 = number2;
    number2 = number3; 
    j++;
} */

/* int [] Fib = new int [size];
Fib [0]=0;
Fib [1]=1;
for (int i = 2; i < size; i++)
{
    Fib[i]=Fib[i-2]+Fib[i-1];
}   */



/* Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 2)
{
    Console.WriteLine("Введите число больше 2");
}
else
{
int number1 = 0;
int number2 = 1;
int number3 = 0;
Console.WriteLine(number1);
Console.WriteLine(number2);
for(int j = 0; j < number; j++)
{
    number3 = number1 + number2;
    Console.WriteLine(number3);
    number1 = number2;
    number2 = number3; 
}
}
 */





/* Задача 45: Напишите программу, которая будет создавать
 копию заданного массива с помощью поэлементного копирования.
 */

 /* int[] array = GetArray(10, 0, 10);
WriteLine(String.Join(" ", array));

int[] copyArray=CopyArray(array);
WriteLine(String.Join(" ", copyArray));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];

    }
    return result;
} */





/* Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
 */


 /* int CountSymbol(char symbol, string text)
{
    int result = 0;
    for (int i=0;i<text.Length;i++)
    {
        if (text[i] == symbol) result++;
    }
    return result;
}

int[] GetArrayFromUser()
{
    int arrayLength = 0;
    Console.Write("Введите числа. Например: '3, 4, 0, -5' > ");
    string userInput = Console.ReadLine();
    // Количество цифр считаю исходя из количества запятых + 1
    int[] numbers = new int[CountSymbol(',', userInput)+1];
    // Теперь перебираю строку, создавая подстроки и
    // пытаясь сохранить результат их парсинга в массиве
    // Как альтернативу можно использовать Strint.Split()
    int i = 0;
    string tmp = "";
    for (int textI=0;textI<userInput.Length;textI++)
    {
        if (userInput[textI] == ',')
        {
            if (! int.TryParse(tmp, out numbers[i]))
            {
                Console.WriteLine($"Не удалось распарсить '{tmp}', число задано как 0");
            }
            tmp = "";
            i++;
        }
        else
        {
            tmp += userInput[textI];
        }
    }
    // Распарсим последний элемент т.к. он не заканчивается ','
    if (! int.TryParse(tmp, out numbers[i]))
        {
            Console.WriteLine($"Не удалось распарсить '{tmp}', число задано как 0");
        }
    return numbers;
}

int CountPositiveNumbers(int[] array)
{
    int result = 0;
    foreach (int num in array)
    {
        if (num > 0) result++;
    }
    return result;
}

int[] userArray = GetArrayFromUser();
Console.WriteLine($"Вы ввели [{String.Join(", ", userArray)}], положительных среди них {CountPositiveNumbers(userArray)}"); */









/* Задача 43: Напишите программу, которая найдёт точку пересечения
 двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
  значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */



int[] GetFunctionParametersFromUser()
{
    int[] result = new int[2];
    Console.Write("Введите через запятую значения переменных для уравнения A*x + B. Например '3,1' > ");
    string userInput = Console.ReadLine();
    int i = 0;
    foreach (string numberStr in userInput.Split(','))
    {
        if (! int.TryParse(numberStr, out result[i]))
        {
            Console.WriteLine($"Не удалось распарсить '{numberStr}', число задано как 0");
        }
        i++;
    }
    return result;
}

double[] FindIntersectionPoints(int[] func1, int[] func2)
{
    double[] combinedFunc = new double[2];
    combinedFunc[0] = func1[0] - func2[0];
    combinedFunc[1] = func1[1] - func2[1];
    double x = -(combinedFunc[1]/combinedFunc[0]);
    double y = func1[0] * x + func1[1];
    return new double[] {x, y};
}

Console.WriteLine("Уравнения y = k1*x + b1 и y = k2*x + b2");
Console.WriteLine("Для первого уравнения");
int[] y1 = GetFunctionParametersFromUser();
Console.WriteLine("Для второго уравнения");
int[] y2 = GetFunctionParametersFromUser();

if (y1[0] == y2[0])
{
    Console.WriteLine("Угловые коэффициенты равны, функции не пересекаются т.к. Параллельны");
}
else
{
    Console.WriteLine($"Функции пересекаются в точке ({String.Join(", ", FindIntersectionPoints(y1, y2))})");
}

double[] point =  FindIntersectionPoints(y1, y2);
char[,] graph = new char[10, 10];

int xStart = (int)point[0] -5;
int yStart = (int)point[1] -5;

for (int i=0;i<graph.GetLength(0);i++)
{
    for (int j=0;j<graph.GetLength(1);j++)
    {
        if (j+yStart == Convert.ToInt32(y1[0]*(xStart+ i) + y1[1]) || j+yStart == Convert.ToInt32(y2[0]*(xStart+i) + y2[1]))// graph[i,j] = '*';
        {
            Console.Write('*');
        }
        else Console.Write(' ');
    }
    Console.WriteLine();
}