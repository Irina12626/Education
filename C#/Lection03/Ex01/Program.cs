// Работа с текстом. Дан текст, в котором нужно заменить все пробелы черточками,
// маленькие буквы к заменить на большие К, а большие С на маленькие с.

//Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            012345
// s[3] // r

string Replace(string text, char OldValue, char NewValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {

        if (text[i] == OldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";
    }
    return result;

}
String newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();