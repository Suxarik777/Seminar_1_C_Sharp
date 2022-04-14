// функция заполнения массива

int[] numbers = new int[5];

FillArray(numbers);

Console.WriteLine(numbers);

void FillArray(int[] array)
{
    int index = 0;
    while(index < numbers.Length)
    {
    numbers[index] = new Random().Next(0, 100); //заполняем массив рандомно от 0 до 99
    index++;
    }
}

// ТипВозвращаемогоЗначения Название(аргументы)
// {
//    тело
// }