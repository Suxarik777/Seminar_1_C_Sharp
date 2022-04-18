/*Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/

Console.WriteLine("Введите номер четверти ");
int quarterNumber = Convert.ToInt32(Console.ReadLine());


if (quarterNumber < 1 || quarterNumber > 4)
{
    Console.WriteLine("Не корректный ввод, у нас всего 4 четверти (1,2,3,4");
}

if(quarterNumber == 1)              
{
    Console.WriteLine($"Диапазон для четверти № {quarterNumber} - \nx (0 до {Int16.MaxValue}) \ny (0 до {Int16.MaxValue})");
}
if(quarterNumber == 2)              
{
    Console.WriteLine($"Диапазон для четверти № {quarterNumber} - \nx ({Int16.MinValue} до 0) \ny (0 до {Int16.MaxValue})");
}
if(quarterNumber == 3)              
{
    Console.WriteLine($"Диапазон для четверти № {quarterNumber} - \nx ({Int16.MinValue} до 0) \ny ({Int16.MinValue} до 0)");
}
if(quarterNumber == 4)              
{
    Console.WriteLine($"Диапазон для четверти № {quarterNumber} - \nx (0 до {Int16.MaxValue}) \ny ({Int16.MinValue} до 0)");
}