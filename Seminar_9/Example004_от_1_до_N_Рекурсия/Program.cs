// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//    N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


int n = InputNumber("Введите значение N ");

Console.WriteLine(OutputFunction(n));



int InputNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int OutputFunction(int num)
{
    if (num == 1)
    {
        return 1;
    }
    Console.Write(OutputFunction(num - 1) + ", ");
    return num;
}