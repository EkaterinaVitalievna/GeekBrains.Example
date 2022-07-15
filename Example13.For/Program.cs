string Method(int count, string text)
{
    string result = String.Empty;//можно в кавычки заложить то, что нужно, мы прописали, что вначале выходит пустая строка
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method(50, "любимая мама ");
Console.WriteLine(res);
