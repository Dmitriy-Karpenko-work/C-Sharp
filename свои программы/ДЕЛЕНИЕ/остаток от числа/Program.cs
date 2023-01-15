Console.Write("Input a number( Введите число ): ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 =num%10;
int num2 =num%100;
int num3 =num%1000;
int num4 =num%10000;
int num5 =num%100000;
int num6 =num%1000000;

Console.Write("СПРАВА налево какое по счету требуется число");
int current = Convert.ToInt32(Console.ReadLine());
if (current == 1)
{
    current = num1;
    Console.WriteLine(num1 + " = Действие которое выполнили " +num+ " % 10");
}
if (current == 2)
{
    current = num2;
    Console.WriteLine(num2 + " = Действие которое выполнили " +num+ " % 100");
}
if (current == 3)
{
    current = num3;
    Console.WriteLine(num3 + " = Действие которое выполнили " +num+ " % 1000");
}
if (current == 4)
{
    current = num4;
    Console.WriteLine(num4 + " = Действие которое выполнили " +num+ " % 10000");
}
if (current == 5)
{
    current = num5;
    Console.WriteLine(num5 + " = Действие которое выполнили " +num+ " % 100000");
}
if (current == 6)
{
    current = num6;
    Console.WriteLine(num6 + " = Действие которое выполнили " +num+ " % 1000000");
}


//dotnet run