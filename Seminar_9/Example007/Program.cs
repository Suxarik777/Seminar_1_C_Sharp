// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int a = InputNumber("Введите значение A ");
int b = InputNumber("Введите значение B ");


Console.WriteLine(OutputFunction(a, b));


int InputNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int OutputFunction(int numStart, int numEnd)
{
    if (numEnd == 0)
    {
        return 0;
    }
    else if(numEnd == 1)
    {
        return numStart;
    }
    return numStart * OutputFunction(numStart, numEnd - 1);;
}