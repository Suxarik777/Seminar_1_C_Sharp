// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза

// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза


int m = InputNumber("Введите количество строк ");
int n = InputNumber("Введите количество столбцов ");

int[,] array = new int[m, n];
FillArray(array);

Console.WriteLine();
Console.WriteLine("Изначальный двумерный массив выглядит так:");
PrintArray(array);

int[] infoArray = new int[10];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int c = 0; c < infoArray.Length; c++)
        {
            if (array[i, j] == c)
            {
                infoArray[c]++;
            }
        }
    }
}

for (int j = 0; j < infoArray.Length; j++)
{
    Console.WriteLine($"Число {j} встречается {infoArray[j]} раз;");
}
Console.WriteLine();





int InputNumber(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10); ;
        }
    }
}

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


