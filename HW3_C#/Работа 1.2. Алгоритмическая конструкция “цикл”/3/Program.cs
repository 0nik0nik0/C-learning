/* 3. Вычисляется и выводится в таблицу с шагом 10 км
стоимость поездки
на автомобиле в зависимости от расстояния S (10 – 90 км).
С клавиатуры вводятся: b - расход бензина на 100 км,
c - цена бензина за 1л литр. (цикл for)
*/


Console.Write("Введите ваш расход бензина на 100км (b) ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите цену бензина за 1л литр (с) ");
double c = double.Parse(Console.ReadLine());

double price = 0;
for (double s= 10; s <= 90; s+=10)
{
    price = b / 100 * s * c;
    Console.WriteLine($"Стоимость поездки на {s} км  {Math.Round(price, 2)} руб.");
}
