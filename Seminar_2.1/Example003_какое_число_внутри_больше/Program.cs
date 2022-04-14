// генерируем число от 0 до 99 и определяем какая цифра внутри больше

int RandomInt(int min, int max)
{
    return new Random().Next(min, max);
}

int MaxNumber(int number1, int number2)
{
    int max = number1;
    if (number2 > number1)
    {
        max = number2;
    }
    return max;
}



int number = RandomInt(10, 100); // функция смотри наверх

int first = number / 10;   //так ищем выделяем первое число
int second = number % 10; //так ищем выделяем второе число

Console.WriteLine(number);

int max = MaxNumber(first, second); //функция смотри наверх
Console.WriteLine(max);




/* первый вариант перед функцией
if (first > second)
{
    Console.WriteLine(first);
}
else
{
    Console.WriteLine(second);
}
*/