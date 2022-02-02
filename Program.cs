/*
Задача: Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8. 
Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/



void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int[] collection)

{
    for (int i = 0; i < collection.Length; i++)
    {
        int count = 0;
        if (collection[i] > 8)
        {
            count++;
        }
    }
}
void ReplaceDigits(int[] collection, int[] newColletion)

{
    for (int i = 0; i < collection.Length; i++)
    {
        int count = 0;
        if (collection[i] > 8)
        {
            collection[i]=collection[j];
        }
    }
}

    int[] array = new int[25];
FillArray(array);
PrintArray(array);
int[] newArray = new int[IndexOf(array)];
PrintArray(array);