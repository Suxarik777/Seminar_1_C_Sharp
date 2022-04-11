Console.WriteLine("Напишите день недели (числа от 1 до 7): ");
int number_day = Convert.ToInt32(Console.ReadLine());

if(number_day > 7)
{
    Console.WriteLine("У нас всего 7 дней недели, введите числа от одного до семи");
}
else if(number_day == 1)
{
   Console.WriteLine("Понедельник"); 
}
else if(number_day == 2)
{
   Console.WriteLine("Вторник"); 
}else if(number_day == 3)
{
   Console.WriteLine("Среда"); 
}
else if(number_day == 4)
{
   Console.WriteLine("Четверг"); 
}
else if(number_day == 5)
{
   Console.WriteLine("Пятница"); 
}
else if(number_day == 6)
{
   Console.WriteLine("Суббота"); 
}
else if(number_day == 7)
{
   Console.WriteLine("Воскресенье"); 
}