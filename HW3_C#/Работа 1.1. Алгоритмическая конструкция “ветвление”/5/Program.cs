/* 5. Проверяется соответствие веса и роста (ввод рост и вес; вывод одного
из сообщений "Норма", "Нужно похудеть", "Нужно поправиться".
Нормальный вес (в кг) = (рост (в см) – 100) ± 10%. (оператор if ) */

Console.WriteLine("Enter your weight(kg): ");
int weight = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your height(cm): ");
int height = int.Parse(Console.ReadLine());



if (weight > (height - 100) * 1.1)
 Console.WriteLine("Sorry, you're FAT");

else if (weight < (height - 100) * 0.9 )
 Console.WriteLine("Go eat smth, you are close to disappear!");

else 
 {Console.WriteLine("Congratulations! Your are perfect!");}
