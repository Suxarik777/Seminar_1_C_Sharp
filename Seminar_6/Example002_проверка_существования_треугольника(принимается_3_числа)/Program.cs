// // Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// // может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

int GetValue() //функция по записи 3 чисел
{
    Console.Write("Введите длину стороны - ");
    return Convert.ToInt32(Console.ReadLine());
}


int[] array = new int[3]; //создаём массив с фиксированной длинной

for (int i = 0; i < array.Length; i++)
{
    array[i] = GetValue();    //по длинне массива записываем
}

//ну и проверяем данные исходя из теоремы в условии
if (array[0] < array[1] + array[2] && array[1] < array[0] + array[2] && array[2] < array[1] + array[0])
{
    Console.WriteLine("Треугольник возможен");
}
else
{
    Console.WriteLine("Упс, не будет треугольника");
}

