/* 4. По введенному номеру месяца выводится название поры года (зима, весна,
лето, осень) и сообщение: сессия, каникулы, 1 семестр, 2 семестр ( if ).
 */

/* string[] array = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" }; */
Console.WriteLine($"Type month number: ");
int month = int.Parse(Console.ReadLine());

if (month < 3 && month > 0 || month == 12) 
    {Console.WriteLine("Winter");
    if (month == 1) Console.WriteLine("Session but then Holidays!");
    else if (month == 2) Console.WriteLine("2nd term");
    else Console.WriteLine("1rd term");}
   
else if (month > 2 && month < 6)
    {Console.WriteLine("Spring");
    if (month < 5) Console.WriteLine("2nd term");
    else Console.WriteLine("Session but then Holidays!");}

else if (month > 5 && month < 9)
    {Console.WriteLine("Summer");
    if (month < 6) Console.WriteLine("Session;( ");
    else Console.WriteLine("Just relax, its Summer time!");}
    

else if (month > 8 && month < 12) 
    Console.WriteLine("Autumn \n1nd term");
     

else {Console.WriteLine($"Hey dude, wake up!");}

