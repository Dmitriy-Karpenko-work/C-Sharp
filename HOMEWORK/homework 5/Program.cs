//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

/*
Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size]; // объявил размер массива

CreateRandonNumbers(numbers);
Console.WriteLine("В этом массиве: ");
PrintArray(numbers);

void CreateRandonNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}


int count = 0; // число четных чисел

for (int x = 0; x < numbers.Length; x++)
{
if (numbers[x] % 2 == 0)
count++;
}
Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


void ShowArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/
/*
//--------------------------------------------------------------------------------------------------
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
//--------------------------------------------------------------------------------------------------


int[] CreateArrayRandom(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void ShowArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
        if (i % 2  != 0) 
        {
        sum += arr[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции, соcтаваляет {sum} ");
    Console.WriteLine();
}
Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateArrayRandom(size));
*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76


int[] CraeteArray(int size) //создание массива
{
    int[] array = new int[size]; 
    for(int i=0; i < size; i++) // индекс первого элемента если индекс вышел больше массива выход из цикла если нет идем к следующиму индексу
        {
            Console.WriteLine("введите элемент ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
                                     
    return array;
}

void ShowArray(int[] array) //метод возврата массива

{   
    int result = 0;
    Console.Write("[ ");
    for(int i=0;i<array.Length;i++)
    {
        Console.Write(+array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();   

    result = array[array.Length]-array[0]; //<-------- ОШИБКА!!!! Index was outside the bounds of the array.   
}
/*
int[] Method(int[] array) //главный метод
{
    int Min= array[0];
    int Max= array[array.Length];// <----- ОШИБКА почему индекс за гранью массива когда он должен быть равен длине массива
    int result = array[array.Length]-array[0];
    return result;
}
*/
Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
int result = 0;
int[] newArray = CraeteArray(size);
ShowArray(newArray);
//Method(newArray);


 //Index was outside the bounds of the array.

