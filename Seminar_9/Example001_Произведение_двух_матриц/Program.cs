// ДЗ к прошлому семинару
// Задача 58
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] ProductMatrix(int[,] matrix1, int [,]matrix2)
{
    if(matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        return matrix1;
    }
    int[,] outputMatrix = new int(matrix1.GetLength(0), matrix2.GetLength(1));
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix2.GetLength(0); j++)
        {
            for(int k = 0; k < matrix1.GetLength(1); k++)
            {
                outputMatrix[i, j] += outputMatrix[i, j] * matrix2[k, j];
            }
        }
    }
    return outputMatrix;
}

