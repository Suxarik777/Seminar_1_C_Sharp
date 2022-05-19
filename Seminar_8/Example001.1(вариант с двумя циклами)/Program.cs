// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.



Console.Write("Введите m (количество строк) ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n (количество столбцов) ");
int n = Convert.ToInt32(Console.ReadLine());
int [,]randomArray = new int[m, n];
FillArray(randomArray);


Console.WriteLine();
Console.WriteLine("Изначальный двумерный массив выглядит так:");

PrintArray(randomArray);

for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); i++)
    {
        int temp = randomArray[0, j];
        randomArray[0, j] = randomArray[n - 1, j];
        randomArray[n - 1, j] = temp;
    }
}

Console.WriteLine();
Console.WriteLine("Помененые строки в двумерном массиве выглядит так:");

PrintArray(randomArray);

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
