﻿//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());
int[] result = new int[number];

GetFibonachiRow(result);
WriteArray(result);

void GetFibonachiRow(int[] result)
{
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < result.Length; i++)
    {
        result[i] = result[i-1] + result[i-2];
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



Console.WriteLine();
// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите количество элементов: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] fibonacci = new int[N];

for (int i = 0; i < fibonacci.Length; i++)    //здесь есть проверка если пользователь захотел ввести 1
{
    if(i==0)
        fibonacci[i] = 0;
    else if(i==1)
        fibonacci[i] = 1;
    else
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
}

PrintArray(fibonacci);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length-1)
            Console.Write(", ");
    }
}