// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


Console.Write("Введите m (количество строк) ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n (количество столбцов) ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = i + j;
    }
}

Console.WriteLine();
Console.WriteLine("Изначальный двумерный массив выглядит так:");

PrintArray(array);

int sum = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
        {
            sum = sum + array[i, j];
        }
    }
}

Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали выглядит так {sum}");




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
