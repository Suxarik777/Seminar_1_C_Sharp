Console.WriteLine("Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.");

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());


if (number1 % number2 == 0) // проверяем на остаток деление от деления числа1 на число2 и если в резульате 0 то кратно,  
{
    Console.WriteLine("Числа кратны");
}
else
{
    Console.WriteLine("Числа не кратно, остаток от делени");
    Console.WriteLine(number1 % number2); // показываем остаток целых чисел так как контейнер int
}
