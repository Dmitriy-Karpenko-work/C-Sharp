﻿
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

/*
Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int result = a; //

for (int i = 1; i < b; i++) // ВАЖНО!!!ИНФОРМАЦИЯ ДЛЯ МЕНЯ!!!ножно запомнить что счетчик можно указывать не только с нуля
{
result = result * a;
}
Console.WriteLine("A в степени B равно: " + result);
*/
/*
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

//-------------------------------------------------------------------------------------------------------------
//набросок решения 1                    второй вариант
//принять число                         узнавать остаток числа в цикле и складывать его пока цыкл перебирает
//узнать кол во индексов в массиве      
//сложить  значение индексов
//выдать как сумму
//-------------------------------------------------------------------------------------------------------------

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number > 0)
    {                                          
        int num = number % 10;  //2//5//4
        number = number / 10;   //45//4//0
        sum = sum + num;        //0+2//2+5//7+4//
    }
Console.WriteLine("сумма всех цифр в числе равна: " + sum);

//-------------------------------------------------------------------------------------------------------------
//вопрос не по теме 
//есть ли индекс у -
//а если -452 мы вырываем [индекс]=1 число 2 она число будет 2 или -2
//-------------------------------------------------------------------------------------------------------------
*/


//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]                 

//6, 1, 33 -> [6, 1, 33]
//
//----------------
//ввесли цыфры через запятую
//посчитать их количество !!!записать!!! - это максимальное число в массиве -1
//присвоить каждому индексу числа по порядку
//вывести на экран string массив
//----------------

/*
  void Main(string[] args)
{
    
    for (int i=0 ; i < myArray.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом{i}");
        MtArray[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Вывод массива");

    for (int i=0 ;i < myArray; i++)
    {
        Console.WriteLine(myArray[i]);
    }

    Console.ReadLine();
}


Console.Write("Введи количество элементов  массива");
int elementsCount = int.Parse(Console.ReadLine());
int[] myArray = new int [elementsCount];

*/


//Задачу не смог сделать хочу разбор на лекции!!!




//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]                 

//6, 1, 33 -> [6, 1, 33]




   //            массив на входе           всего                      
int[] CraeteArray(int number,           int size) //агрументы 
{
    int[] array = new int[size]; //{number}; //запомнить!!!динамическое выделение помять под перемену INT [колво элементов в массиве]
    for(int i=0; i < size; i++) // индекс первого элемента если индекс вышел больше массива выход из цикла если нет идем к следующиму индексу
        array[i] = number; // присвоение индексу цыфры //ПРИСВАИВАЕТСЯ ПОСТОЯННО ОДНО ЧИСЛО
                                     //for(int i=0; i < number; i++)
    return array;
}

void showArray(int[] array) //метод возврата массива
{
    for(int i=0;i<array.Length;i++)
        Console.WriteLine("["+array[i] + " " + "]");

    Console.WriteLine();        
}




Console.WriteLine("Длинна массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите элементы ");
int elements = Convert.ToInt32(Console.ReadLine());

int[] newArray = CraeteArray(elements,size);
showArray(newArray);



//Console.WriteLine("введите элементы");
//Number.[i] = int.Parse(Console.ReadLine)
