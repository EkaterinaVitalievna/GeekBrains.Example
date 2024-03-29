﻿// Заменить в тексте пробелы на дефисы, строчные буквы к на заглавные, а заглавные В - на строчные в.
string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого "
            + "Винценгероде, вы бы взяли приступом согласие "
            + "прусского короля. Вы так красноречивы. Вы "
            + "дадите мне чаю?";

// string s m "qwerty"
//             012345
//s[3] / r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'В', 'в');
Console.WriteLine(newText);