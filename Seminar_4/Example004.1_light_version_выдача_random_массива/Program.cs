﻿// Напишите программу которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке
// [0 1 0 0 1 1 0 1]

int[] array = new int[8];

for(int index = 0; index < array.Length; index++)
{
    array[index] = new Random().Next(0, 2);
    Console.Write(array[index] + " ");
}