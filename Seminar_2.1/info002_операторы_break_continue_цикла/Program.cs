int length = data.Length;
int index = 0;

while (index < length)
{
    if (index == 5)
    {
        continue    ЭТО ЗНАЧИТ ЧТО ЦИФРУ 5 ЦИКЛ ПРОПУСТИТ
    }
    if (index == 5)
    {
        break    ЭТО ЗНАЧИТ ЧТО ЕСЛИ ВЫПАДИТ ЦИФРА 5 ЦИКЛ ЗАВЕРШИТСЯ
    }
    else
    {
        index++;
    }
}