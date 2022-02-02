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
        collection[index] = new Random ().Next(1,10);
        index++;
    }
}
void PrintArray (int[] col)
{
int count = col.Length;
int position = 0;
while (position < count)
{
    Console.WriteLine( col[position]);
    position++;
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index <count)
    {
        if (collection[index] == find)
        {
            position=index;
        
        }
        index++;
    }
    return position;
}

int [] array = new int[25];
FillArray(array);
PrintArray(array);
int find =8;
IndexOf(array);