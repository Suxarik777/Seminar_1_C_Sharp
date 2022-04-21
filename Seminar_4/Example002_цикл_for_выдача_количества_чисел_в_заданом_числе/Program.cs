// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе

Console.WriteLine("Введите число");
string number = Console.ReadLine();


//первый вариант решения
//int qty = number.Length;

//Console.WriteLine(qty);


//второй вариант решения
int result = 0;

for(int index = 0; index < number.Length; index++)
{
    result++;
}
Console.WriteLine(result);


