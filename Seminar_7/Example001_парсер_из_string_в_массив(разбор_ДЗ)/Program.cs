// Парсер введёных срокой чисел в числовой массив

string output = "2, 56, 78, 78, 4, 5";
Console.WriteLine("Изначальный массив в строке выглядит так:");
Console.WriteLine(output);

int countNumbers = 1;                   //  здесь узнаём длинну массива
for(int i =0; i < output.Length; i++)
{
    if (output[i] ==  ',')
    countNumbers++;
}

int[] numbers = new int [countNumbers]; // вписываем эту длинну

int numberIndex = 0;
for(int i = 0; i < output.Length; i++)
{
    string subString = String.Empty;    // пустая строка

    while (output[i] != ',')
    {
        subString += output[i].ToString();
         
        if (i >= output.Length - 1)         // тут тормозим по индексу относительно длинны индекса (-1 потому что индекс от 0)
        break;
 
        i++;
    }

    if(subString == "" || subString == " ")
    continue;

    numbers[numberIndex] = Convert.ToInt32(subString);
    numberIndex++;
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}


