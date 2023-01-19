//масив с рандомной генерацией
int[] CraeteRandomArray(int size,int minValue,int maxValue) //агрументы размер
{
    int[] array = new int[size]; //запомнить!!!динамическое выделение помять под перемену INT [колво элементов в массиве]

    for(int i = 0; i < size; i++)
        array[i] = new Randon().Next(minValue, maxValue +1);// maxValue+1 верхний диапазон читается НЕВКЛЮЧИТЕЛЬНО

    return array;
}