// Напишите программу, 
//которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

//                                      изначально ввод сделали линейно
/*Console.WriteLine("Введите координату x точки A ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки A ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x точки B ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки B ");
int yB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введёные координаты точки А - {xA} , {yA} ");
Console.WriteLine($"Введёные координаты точки B - {xB} и {yB} ");*/


//                          сделали ввод через функцию
int xA = Coordinate("x", "A");
int yA = Coordinate("y", "A");

int xB = Coordinate("x", "B");
int yB = Coordinate("y", "B");

//                              функция по вводу данных
int Coordinate(string coorName, string pointName)
{
    Console.WriteLine($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}



int diffX = xB - xA; // вычесление длины первого катета (смотри на рисунок)
int diffY = yB - yA; // вычесление длины второго катета   (смотри на рисунок)

//ищем гипотенузу //A = √(X²+Y²) - гипотинуза равна сумме квадратов катетов
double result = Math.Sqrt(Math.Pow(diffX,2) + Math.Pow(diffY,2)); 
                //Math.Sqrt высчитывает корень
                            //Math.Pow возводит в квадрат (то что мы возводим, в какую степень возводим2)

Console.WriteLine($"Расстояние между точками A и B - {result}");
