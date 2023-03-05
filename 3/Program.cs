/*
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// Создание двумерного массива, заполненного псевдослучайными числами
int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],4}");
            else Console.Write($"{matr[i, j],4}");
        }
        Console.WriteLine();
    }
}

double[] FindArMean(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int m= 0; m < matrix.GetLength(1); m++)
    {
        for (int k = 0; k < matrix.GetLength(0); k++)
        {
            array[m] += matrix[k, m];
        }
        array[m] /= matrix.GetLength(0);
        array[m] = Math.Round(array[m], 1, MidpointRounding.AwayFromZero);
    }
    return array;
}
// Печать среднее арифметических значений через разделитель |
void PrintArrDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write(array[i] + " | ");
        else
            Console.Write(array[i]);
    }
}

int[,] array2D = GetMatrix(3, 4, 1, 9);
PrintMatrix(array2D);

double[] arrArithmeticMean = FindArMean(array2D);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArrDouble(arrArithmeticMean);