// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*

void showNum (int[] a)

{
    a[0] += 5;
    Console.WriteLine(a[0]);
}

    int[] num = {5,7,3};

showNum(num);
Console.WriteLine(num[0]);

for 

*/

//Задача 1 напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//подсказка
//сумма двух строно всегда больше третей стороны
//----------------------------------------------------------------------------

/*

bool Triangle (int a, int b,int c)
{
 if (a+b>c && b+c>a && c+a>b)
 return true;
 else
 return false;
}

Console.WriteLine("сторона 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("сторона 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("сторона 3");
int c = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(a,b,c) ;
Console.WriteLine(result);

*/

//Задача 2
//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//посказка
//последовательность каждое последующее число равно сумма двух предыдущих
//F(n) = F(n-1) + F(n-2)
////сгенерируем массив! нулевой элемент и первый запустить до тога как сформируем цикл

//----------------------------------------------------------------------------
/*
int[] RandomArray(int a,int b, int size)
{
    int[] array = new int[size];
    array[0] = a;
    array[1] = b;
    for (int i = 2; i < size; i++)
        array[i] = array[i-2] + array[i-1];

    return array;
}

void ShowArray(int[] array) 
{
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");

	Console.WriteLine();
}



Console.WriteLine("первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("размер ряда Фибоначчи");
int size = Convert.ToInt32(Console.ReadLine());

int[] result = RandomArray(a,b,size);
ShowArray(result);


*/


//Задача 3 Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
//массив на вход на выходе "массив"
//-----------------------------------------------------------------------------




int[] RandomArray(int size, int minValue, int maxValue)
{
	int[] array = new int[size];

	for (int i = 0; i < size; i++)
		array[i] = new Random().Next(minValue, maxValue + 1);
	return array;
}

int[] CopyArray(int[] array,int size) //запомнить
{
    int[] newarray = new int[size];

    for (int i=0; i < array.Length;i++)
        newarray[i] = array[i];
    return newarray;

}



void ShowArray(int[] array) // запомнить
{
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");

	Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = RandomArray(m, min, max);

ShowArray(newArray);
