// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К", а большие "C" заменить маленькими "c".


string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
                + "ежели бы вас послали вместо нашего милого Винценгероде,";
//string s = "qwerty"  - строка
// s[3] // r  - обращение к третьему элементу строки "r"

string Replace (string text, char oldValue, char newValue)
{
     string result = String.Empty;

     int length = text.Length;
     for (int i = 0; i < length; i++)
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
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);