Console.WriteLine("Введите два числа и мы посчитаем кратно ли второе число первому и выведем остаток от деления");

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Proverka(numberA, numberB);

void Proverka(int numberA, int numberB)
{
        if(numberB < numberA)
        {
            Console.WriteLine("Ошибка, второе число меньше первого");
        }
        else
        {
            int result = numberB % numberA;
            if(result == 0)
            {
                Console.WriteLine("Второе число " + numberB + " кратно первому числу " + numberA);
            }
            else
            {
                Console.WriteLine("Второе число " + numberB + " НЕ кратно первому числу " + numberA);
                Console.WriteLine("Остаток от деления " + result);
            }
        }
}