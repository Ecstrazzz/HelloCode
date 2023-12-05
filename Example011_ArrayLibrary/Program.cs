void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
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

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine("-------");
Console.WriteLine("Введите число необходимого элемента: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-------");

int pos = IndexOf(array, num);
if (pos!=-1)
{
    Console.WriteLine($"Индекс элемента в массиве: {pos}");
}
else Console.WriteLine("Элемент не найден в массиве");
Console.WriteLine("-------");