//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//маленькими “с”.


string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде, "
+ "вы бы взяли приступом согласиепрусского короля. "
+ "Вы так красноречивы. Выдадите мне чаю?";


//String s = "qwert"
//            01234
//s[3] // s = r

string Replace(string text,char oldValue,char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i=0;i<lenght;i++)
    {
        if(text[i]== oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string NewText = Replace(text, ' ' ,'|');
Console.WriteLine(NewText);