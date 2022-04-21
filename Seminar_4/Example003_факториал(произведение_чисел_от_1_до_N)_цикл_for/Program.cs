// Напишиате программу, котораля принимает на вход число N и выдаёт произведение чисел от 1 до N
// то есть факториал
// 4 ->24
// 5 -> 120

Console.WriteLine("Введите число");

int length = Convert.ToInt32(Console.ReadLine());

int factorial = 1;

for(int index = 1; index <= length; index++)
{
    factorial *= index;
    //factorial = factorial * index; // первая операция 1 factorial на 1 index = 1, счетчик щелкнул 1 * 2 = 2,  2 * 3 = 6, 6 * 4 = 24  
}

Console.WriteLine($"Произведение (факториал) чисел от 1 до {length}: {factorial}");