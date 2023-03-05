/*
Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

double[,] GetMatrixDouble(int rows, int cols, int minValue, int maxValue)
{
    double[,] matrix = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 1, MidpointRounding.AwayFromZero);
            // Придерживаясь своего стиля округленния.
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            if (m < matr.GetLength(1) - 1) Console.Write($"{matr[i, m],6}");
            else Console.Write($"{matr[i, m],6}");
        }
        Console.WriteLine();
    }
}

double[,] array2D = GetMatrixDouble(3, 4, -10, 10);
PrintMatrix(array2D);