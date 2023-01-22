int[] CreateRandomArray(int size,int minValue,int maxValue)
{
 //[ничего писать]    [размер массива]
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue,maxValue +1);

    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("введите размер массива " );
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите мин значение" );
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите макс значение" );
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size,minValue,maxValue); // присвоение Массиву newArray = Метод(аргументы на входе)

ShowArray(newArray); //демонстрация актуального состояния массива