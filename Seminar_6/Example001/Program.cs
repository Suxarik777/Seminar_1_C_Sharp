// Напишиет программу, которая перевернёт одномерный массив 
//(последний элемент будет на первос месте, а последний )

int[] array = GetArray(6);
WriteArray(array);
for(int i = 0; i < array.Length / 2; i++)
{
    int help = array[i];
    array[i] = array[array.Length - 1 -i];
    array[array.Length - 1 -i] = help;
}
WriteArray(array);


int[] GetArray(int length)  // инициализация массива (сохздание нового) нового массива
{
    int[] newArray = new int[length];
    FillArray(newArray);
    return newArray;
}


void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }
    Console.WriteLine();
}