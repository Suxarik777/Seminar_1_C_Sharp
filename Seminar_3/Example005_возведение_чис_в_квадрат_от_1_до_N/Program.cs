/*Задача 22: Напишите программу, которая принимает на 
вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.WriteLine("Введите число N ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ваше число " + number + " в квадрате");

int index = 1;


if (number <= 0)
{
    Console.WriteLine("Некорректный ввод!");
}

while (number >= index)
{
    double result = Square(index); //это функция по возведению в квадрат смотри ниже
    Console.WriteLine(result + " ");
    index++;
}

double Square(int number)
{
    return Math.Pow(number,2); //команда возведение в степень
}