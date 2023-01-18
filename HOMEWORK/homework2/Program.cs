//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

/*
Console.WriteLine("Введите трехзначное число : ");
int a = Convert.ToInt32(Console.ReadLine()); 
int number = a%100 / 10 ;
Console.WriteLine(number);
/*

/*

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
*/

/*
Console.Write("Введите любое число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
int ThirdNumber(int number) // метод
{
  while (number > 1000)
  {
    number = number / 10;
  }
  number = number % 10;
  return number;
}
if (anyNumber < 100)
{
  Console.WriteLine("Третьей цифры нет");
}
else
{
  Console.WriteLine("Третья цифра этого числа: " + ThirdNumber(anyNumber));
}

*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

bool Weekend(int day) // мотод bool
{
  if (day == 6 || day == 7) return true;
  else return false;
}
 // конец метода
Console.Write("вход цифру, обозначающую день недели: ");
int yourDay = Convert.ToInt32(Console.ReadLine());
if (Weekend(yourDay))
{
  Console.WriteLine("да,это выходной");
}
else
{
  Console.WriteLine("нет,это не выходной");
}