// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


int[] numbers = new int [6];
FillArray(numbers);
PrintArray(numbers);

Console.WriteLine(" ");
Console.WriteLine("Массив в негативе ");
for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = -numbers[i];
    Console.Write(numbers[i] + " ");
}

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

