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

for (int i = 0; i < randomArray.GetLength(1); i++)   // бежим по столбцам и записываем первую цифру в первой строке
                                                    // в последниюю строку
{
    int temp = randomArray[0, i];
    randomArray[0, i] = randomArray[m- 1, i];
    randomArray[m - 1, i] = temp;
}

Console.WriteLine();
Console.WriteLine("Помененые строки в двумерном массиве выглядит так:");

PrintArray(randomArray);

void FillArray(int [,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);;
        }
    }
}

// Функция печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
