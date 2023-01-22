// задача 1 .Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*
int GetSum (int num) // метод
{
    int sum = 0;

    for(int current=0;current<=num;current++)
        sum += current; // += - sum = sum + current;
    return sum;
}

Console.Write("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.Write(GetSum(a));

// можно так Console.Write(GetSum(a));
*/
/*
//задача 1.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//на вход берет число
//число делится
int InfoDigit(int num)
{
int count = 0;//count количество цифр в числе
for (int current = 0;num >0;current++ )
    {
    count = count/10; 
    }
    return count;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(InfoDigit(a));

*/

/*
//задача 2 Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
int GetSum (int num) // метод
{
    int sum = 1;

    for(int current=1;current<=num;current++) // current 
        sum *= current; // += - sum = sum + current;
    return sum;
}

Console.Write("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.Write(GetSum(a));

//1*2*3*4*5




