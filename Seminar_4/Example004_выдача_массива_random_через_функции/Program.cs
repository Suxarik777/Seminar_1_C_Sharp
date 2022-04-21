// Напишите программу которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке
// [0 1 0 0 1 1 0 1]

Console.WriteLine("Введите размер массива: ");

int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] array = new int[lengthArray];

array = GenerateArray(lengthArray);

PrintArray(array);

int[] GenerateArray(int len)
{
    int[] arr = new int[len];
    for(int index = 0; index < len; index++)
    {
        arr[index] = new Random().Next(0,2); 
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for(int index = 0; index < arr.Length; index++)
    {
        Console.Write(arr[index] + " ");
    }
}




