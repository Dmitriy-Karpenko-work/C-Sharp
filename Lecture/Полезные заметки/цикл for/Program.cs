//ВАЖНО!!!
string Method4(int count, string text) //МЕТОД склеивание текста скольео то раз
{
    String result = String.Empty; // String result = "" // изначально пусто в строке
    for( int i = 0; i < count;i++) // цикл   // целое число изначально равно нулю; когда счетчик будет больше целого числа выйти из цикла;каждый цикл повысить на 1
        {
         result = result + text; // результат
        }
    
    return result; // возврат результата
}
string res = Method4(text: "lorem ipsum ",count:101 ); // вызов метода и присваивание метода к переменной res
Console.WriteLine(res); //забыли про метод и работаем дальше