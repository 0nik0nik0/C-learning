// type 1 (не принимают и не возвращают)
/* void Method1()
{
    Console.WriteLine("Author Nikita M");
}
Method1(); //обязательно нужны скобки */







/* // type 2 (принимают но не возвращают)
void Method2(string msg)
{
    Console.WriteLine(msg);
}

/* Method2("msg text"); */
/* Method2(msg:"msg text");  - именованный аргумент*/

/* void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // инкремент (увеличение на ед.)
    }
    
}

Method21(msg: "TEXT", count: 4);
Method21(count: 4, msg: "new text" ); */







//Type 3 (возвращают но не принимают)

/* int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year); */





// Type 4 (принимают и возвращают)

/* string Method4(int count, string text)
{
    int i = 0;
    string result = ""; // Sring.Empty

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;    
} */
string Method4(int count, string text)
{
    
    string result = ""; // Sring.Empty
for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;   
}
string result = Method4(10, "Hello ");
Console.WriteLine(result);


