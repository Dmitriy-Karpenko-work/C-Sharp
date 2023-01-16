//не работает ХЗ почему




void FillArray(int[] collection) // метод заполнил массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++; //index = index +1;
    }
}
void PrintArray(int[] col) // метод  распечатал
{
    int count = col.Length;
    int possitiont = 0;
    while(possitiont<count)
    {
        Console.WriteLine(col[possitiont]);
        possitiont++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index <count)
    {
        if(collection[index] == find)
        break;
    }
    index++;
    return position;
}




int[] array = new int[10]; // создай новый массив в котором будет 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);