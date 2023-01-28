// 1 type

void Method1()  // Void метод ничего не возвращает
{
    Console.WriteLine("Автор ...");
}
Method1();

// 2 type

void Method2(string msg)
{
    Console.Write(msg); 
}
Method2("Текст сообщения")

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст сообщения", count: 4); // или
Method21(count: 4, msg: "Новый текст"); 

//Type 3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine (year);

//Type 4

string Method4 (int count, string text)
{
    string result = string.Empty;
    int i = 0;

    while (i < count)
    { 
       result = result + text;
       i++;  
    }
    return result;
}