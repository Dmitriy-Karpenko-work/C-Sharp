/*

// вид 1
void Method1()
{
    Console.WriteLine("Автор Дмитрий К.");
}
//Method1(); //ВЫКЛ



// вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("текст сообщения");
void Method21(string msg,int count) //метод Method21(сообщение,сколько раз хочу увидеть)
{
     int i=0;
    while(i<count)
    {
         Console.WriteLine(msg);
         i++;
    }
}
//Method21(msg: "текст сообщения",count: 4);
//Method21(count: 4,msg: "текст сообщения"); //можно писать в любом порядке если аргументы именованы

*/
/*
// вид 3
int Method3()
{
    return DateTime.Now.year;
}
int year = Method3(); //вызов метода
Console.WriteLine(year); //в дальнейшем использовать переменную


//Если хотим вызвать дату...время...и т.д.
*/


// вид 4
//ВАЖНО!!!
string Method4(int count, string text) //МЕТОД склеивание текста скольео то раз
{
    int i = 0; // счетчик
    String result = String.Empty; // String result = "" // изначально пусто в строке
    
        while (i < count) // цикл
        {
         result = result + text; // результат
        i++; // счкетчик +1
        }
    
    return result; // возврат результата
}
string res = Method4(text: "lorem ipsum ",count:1011 ); // вызов метода и присваивание метода к переменной res
Console.WriteLine(res); //забыли про метод и работаем дальше