
// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


Console.Write("Введите m (количество строк) ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n (количество столбцов) ");
int n = Convert.ToInt32(Console.ReadLine());
int [,]array = new int[m, n];
FillArray(array);


Console.WriteLine();
Console.WriteLine("Изначальный двумерный массив выглядит так:");

PrintArray(array);

if(array.GetLength(0) == array.GetLength(1))
{
    int[,] arrayReverse = new int[array.GetLength(1), array.GetLength(0)];

    ReverseArray(array, arrayReverse);
    Console.WriteLine();
    Console.WriteLine("Строки вместо столбца и наоборот выглядят так");    
    PrintArray(arrayReverse);
}
else
{
    Console.WriteLine();
    Console.WriteLine("Выполнить задачу нельзя");
}



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

void ReverseArray(int[,] array, int[,] arrayReverse )
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        arrayReverse[i,j] = array[j,i];
      }
    }
  }