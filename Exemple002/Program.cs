Console.WriteLine("Задайте первое число, квадрат которого мы будем проверять по отношению ко второму числу: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе число :");
int numberA = Convert.ToInt32(Console.ReadLine());

if(numberA * numberA == numberB)
{
    Console.WriteLine("Да заданое вами первое число, является квадратом второго");
}
else
{
    Console.WriteLine("Нет эти числа не имеют ни какой связи");
}


//1. Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом
//второго.
//a = 5; b = 25 -> да
//a = 2 b = 10 -> нет
//a = 9; b = -3 -> нет
//a = -3 b = 9 -> да