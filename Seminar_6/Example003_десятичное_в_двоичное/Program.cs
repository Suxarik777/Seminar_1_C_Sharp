// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ваше число - {number}");

string helpResult = string.Empty;  // будем писать значение в строку, чтобы избежать математического + а добавлять числа по порядку
string result = string.Empty;   // верхняя строка вспомогательная, нижняя основная

while (number != 0)   //пока число при делении не превратилось в 0
{
    helpResult = helpResult + number % 2; //мы в вспомогательную строку записываем numbr делённый с остатком на 2
    number = number / 2; //ну а это мы щёлкаем для щетчика Вайли
}
Console.WriteLine($"Число в двоичной не перевернутое - {helpResult}"); //и тут мы получаем число перевёрнутое

for(int i = 0; i < helpResult.Length; i++) //ну а тут циклом мы быстренько пробегаем записывая переворот в основную строку
{
    result = result + helpResult[helpResult.Length - 1 - i];
}

Console.WriteLine($"Число в двоичной системе - {result}");


Console.WriteLine();


//второй вариант решение через запись ответа в массив
Console.WriteLine("Второй вариант решение через запись ответа в массив");

Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());

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