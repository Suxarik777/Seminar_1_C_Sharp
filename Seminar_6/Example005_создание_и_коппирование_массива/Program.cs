// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

Console.WriteLine("Введите длину массива");
int arrayLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Искомый массив");
int[] firstArr = GetArray(arrayLength);

WriteArray(firstArr);

int[] secondArr = new int[arrayLength];

for (int i = 0; i < firstArr.Length; i++)
{
    secondArr[i] = firstArr[i];
}

Console.WriteLine("Копия искомого массива");

WriteArray(secondArr);

int[] GetArray(int length)
{
    int[] newArray = new int[length];
    FillArray(newArray);
    return newArray;
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}



