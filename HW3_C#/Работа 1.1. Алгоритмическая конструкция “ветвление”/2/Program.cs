/* 2. Генерируются два случайных целых числа a и b в интервале [10 – 30].
Если a > b, выводится их разность, eсли a < b, выводится сумма,
eсли a == b, выводится сообщение “числа равны”. (оператор if)
 */


int A = new Random().Next(10, 31); 
int B = new Random().Next(10, 31); 
Console.WriteLine($"Cгенерирированное случайное целое число (A): {A}"); 
Console.WriteLine($"Cгенерирированное случайное целое число (B): {B}"); 
string mes = "";

if (A>B) mes =($"Разность А и В = {A-B}");
if  (A<B) mes =($"Сумма А и В = {A+B}");
else if (A==B) mes ="Числа равны";

Console.WriteLine(mes);
Console.ReadKey();

 