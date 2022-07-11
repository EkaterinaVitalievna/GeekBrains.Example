//Нахождение максимального значения с использованием генератора случайных чисел, заполнение массива нужным кол-вом элементов
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random ().Next(1, 10);//обращаемся к аргументу collection на позицию index и заполняем целым случайным числом из диапазона 1-10
        index++;
    }
}

void PrintArray(int[] col)//печатает массив
{
    int count = col.Length;//обозначили кол-во элементов
    int position = 0;//обозначили текущую позицию
    while (position < count)
    {
        Console.WriteLine(col[position]);//вывод значения текущего элемента
        position++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;// элемент не найден
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int [10];//определили массив из 10 элементов

FillArray(array);//заполнили массив
array[4] = 4;
array[6] = 4;
PrintArray(array);//вывел массив
Console.WriteLine();

int pos = IndexOff(array, 4);
Console.WriteLine(pos);