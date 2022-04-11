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
