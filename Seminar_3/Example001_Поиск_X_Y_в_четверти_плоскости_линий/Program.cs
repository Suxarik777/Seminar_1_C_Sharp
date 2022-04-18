// найти точку в плоскости линий X и Y (то есть у нас условное разделение квадрата
// на 4 части)


Console.WriteLine("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("X и Y не могут быть равны 0");
}

int quarterNumber = 0;
if(x>0 && y>0)              //в теории это условие можно убрать (сделать его номинальным) а уже со второй четверти перебирать
{
    quarterNumber = 1;
}
if(x<0 && y>0)
{
    quarterNumber = 2;
}
if(x<0 && y<0)
{
    quarterNumber = 3;
}
if(x>0 && y<0)
{
    quarterNumber = 4;
}

Console.WriteLine($"Точка находится в четверти {quarterNumber}");