/*  1. Генерируется случайное целое число n в интервале [ 20 – 99 ].
Проверяется, делится ли оно на введенное с клавиатуры целое число d
(используйте тернарный оператор).
 */

 Random rnd = new Random(); // создаем экземпляр класса Random
// генерируем случайное целое число в интервале 20, 99
int n = rnd.Next(20, 100);
Console.WriteLine($"Generated random number (n): {n}"); 
Console.WriteLine("Type integer numder (b) ");
// ввод строки и преобразование в целое число
int b = int.Parse(Console.ReadLine());
// используем тернарный оператор
string mes1 = (n % b == 0) ?  "n divided into b" : "n not divisible by b";
Console.WriteLine(mes1);
Console.ReadKey();