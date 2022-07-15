// 4 Группы методов
// 1 группа методов
void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1();//скобочки обязательны



// 2 группа методов
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("вводим нужный нам текст");
//как вариант
//Method2(msg: "вводим нужный и т.д.")
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Учиться полезно", 4);//текст в кавычках выводится 4 раза, цифру указываем сами
//если мы указываем название аргумента, то можно их прописывать не соблюдая очерёдность:
//Method21(count: 5, msg: "новый самый важный текст");

int Method3()
    {
        return DateTime.Now.Year;
    }

int year = Method3();
//Console.WriteLine(year);

//Группа 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;//можно в кавычки заложить то, что нужно, мы прописали, что вначале выходит пустая строка

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(5, "крапиволистный колокольчик, ");
// Console.WriteLine(res);
