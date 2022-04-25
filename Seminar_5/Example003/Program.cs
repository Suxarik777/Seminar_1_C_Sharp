// Задача 33: Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int[] numbers = new int [6];
FillArray(numbers);
PrintArray(numbers);

Console.WriteLine(" ");
Console.Write("Введите число, которое мы будеи искать в массиве ");
int a = Convert.ToInt32(Console.ReadLine());
    
for(int i = 0; i < numbers.Length; i++)
{
    if(a == numbers[i])
    {
        Console.WriteLine($"Число {a} присутствует в массиве");
        return;
    }
}
Console.WriteLine($"Число {a} отсутствует в массиве");

void FillArray(int[] array)
{
    Console.WriteLine("Введите числа от -9 до 9, всего 6 элементов");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент № " + (i + 1) + " ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine("Вы ввели следующий массив");
    for(int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i] + " ");
    }
}

