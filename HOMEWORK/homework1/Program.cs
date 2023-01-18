//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*


Console.WriteLine("Input a number 1(Введите число 1): ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number 2(Введите число 2): ");
int b1 = Convert.ToInt32(Console.ReadLine());
int max1 = 0;
int max2 = 1;
Console.Clear();
if(a1>b1)
{
    max1=a1;
    max2=b1;
    Console.WriteLine($"Большее число: {max1}");
    Console.WriteLine($"Меньшее число: {max2}");
}
else
{
    max1=b1;
    max2=a1;
    Console.WriteLine($"Большее число: {max1}");
    Console.WriteLine($"Меньшее число: {max2}");
}

*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
/*
Console.WriteLine("Input a number 1(Введите число 1): ");
int a = Convert.ToInt32(Console.ReadLine()); //1
Console.WriteLine("Input a number 2(Введите число 2): ");
int b = Convert.ToInt32(Console.ReadLine()); //2
Console.WriteLine("Input a number 3(Введите число 3): ");
int c = Convert.ToInt32(Console.ReadLine()); //3
int max = a;

if (a > b && a > c) max =a;
if (b > a && b > c) max =b;
if (c > a && c > b) max =c;
 Console.WriteLine($"Большее число: {max}");


 */
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
/*
Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine()); //1
if (a%2!=0) Console.WriteLine($"является не чётным");
else Console.WriteLine($"является чётным");
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
/*
Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
int num=0;
while (num < a)
{
    num++;
    if (num % 2 == 0)
    Console.Write($"{num} ");
}
*/
