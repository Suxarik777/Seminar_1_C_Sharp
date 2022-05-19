// Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


int m = InputNumber("Введите значение M ");
int n = InputNumber("Введите значение N ");

if(m > n)
{
    while(m > n)
    {
        Console.WriteLine(" Упс проблема, M должно быть меньше N");
        m = InputNumber("Введите значение M ");
        n = InputNumber("Введите значение N ");
    }
}

Console.WriteLine(OutputFunction(m, n));


int InputNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int OutputFunction(int numStart, int numEnd)
{
    if (numEnd == numStart)
    {
        return numEnd;
    }
    Console.Write(OutputFunction(numStart, numEnd - 1) + ", ");
    return numEnd;
}

