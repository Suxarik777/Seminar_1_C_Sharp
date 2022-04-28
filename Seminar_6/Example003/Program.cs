// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ваше число - {number}");

string tempResult = string.Empty;
string result = string.Empty;

while (number != 0)
{
    tempResult = tempResult + number % 2;
    number = number / 2;
}
Console.WriteLine($"Число в двоичной не перевернутое - {tempResult}");

for(int i = 0; i < tempResult.Length; i++)
{
    result = result + tempResult[tempResult.Length - 1 - i];
}

Console.WriteLine($"Число в двоичной системе - {result}");


Console.WriteLine();

//второй вариант решение через запись ответа в массив
Console.WriteLine("второй вариант решение через запись ответа в массив");


int numb = 8;//new Random().Next(0, int.MaxValue); //вводим число

int binSize = 0; //переменная для подсчёта длинны массива

int tempNumb = numb;
while (tempNumb != 0)
{
    tempNumb /= 2;
    binSize++;                  //перебирая целочисленным делением (количеством делений) мы понимаем длинну массива
}

int[] binArray = new int[binSize];  //и таким образом мы при помощи этой переменной понимаем сколько индексов в массиве на заранее нужно
tempNumb = numb;
for (int i = binArray.Length - 1; i >= 0; i--)
{
    binArray[i] = tempNumb % 2;
    tempNumb /= 2;
}

Console.WriteLine($"number = {numb}");
PrintArray(binArray);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}
Console.WriteLine();