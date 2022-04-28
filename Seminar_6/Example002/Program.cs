// // Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// // может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

int GetValue()
{
    Console.Write("Введите длину стороны - ");
    return Convert.ToInt32(Console.ReadLine());
}


int[] array = new int[3];

for (int i = 0; i < array.Length; i++)
{
    array[i] = GetValue();
}

if (array[0] < array[1] + array[2] && array[1] < array[0] + array[2] && array[2] < array[1] + array[0])
{
    Console.WriteLine("Треугольник возможен");
}
else
{
    Console.WriteLine("Упс, не будет треугольника");
}

