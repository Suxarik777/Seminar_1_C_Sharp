// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.WriteLine("Введите число ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [Length];

FillArray(numbers);
PrintArray(numbers);

int LengthSum;              //переменная будущая длинна нового массива
if(Length % 2 == 0)             //здесь записываем длинну нового массива, если четный то просто делим поплам
{
    LengthSum = Length / 2;
}
else                            //если не четный то пополам плюс 1
{
    LengthSum = (Length / 2) + 1;
}

int[] sumArray = new int[LengthSum];    //таким образом массив у на

for(int i = 0; i < sumArray.Length; i++)
{
    sumArray[i] = numbers[i] * numbers[numbers.Length - 1 - i];
}
if(Length % 2 != 0)             //проверка когда массив не четный число по центру просто записываем число
{
    sumArray[sumArray.Length - 1] = numbers[sumArray.Length - 1]; // тут мы тупо по индексу нового массива 
                                                //(который является половинкой) записываем нужное нам значение , как раз это по середине основного массива 
}
PrintArray(sumArray);


void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 200);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine(" ");
    Console.WriteLine("Массив выглядит так");
    for(int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i] + " ");
    }
}
