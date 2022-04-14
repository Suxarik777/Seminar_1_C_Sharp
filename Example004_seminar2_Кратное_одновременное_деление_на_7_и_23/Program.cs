//Напишите программу, которая принимает на
//вход число и проверяет, кратно ли оно
//одновременно 7 и 23.

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int result1 = number % 7;
int result2 = number % 23;

if (result1 == 0 && result2 == 0)
{
    Console.WriteLine("Число " + number + " кратно числам 7 и 23");
}
else
{
    Console.WriteLine("Число " + number + " НЕ кратно числам 7 и 23");
}