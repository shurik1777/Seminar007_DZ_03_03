/*
Задача доп. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и считает сумму значений в этом массиве по диагонале.

Например, задан массив:

1 4 7

5 9 2

8 4 2
1+9+2 = 12
7+9+8 = 24
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
// использовать метод для распечатывания
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == i) Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{matr[i, j]}\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("\t\tЭлементы массива"); // заголовок
int[,] array2D = GetMatrix(6, 6, 1, 9);
PrintMatrix(array2D); // распечатать массив
int Diag = 0, DownTr = 0, UpTr = 0; // задать параметры 
for (int i = 0; i < array2D.GetLength(0); i++)
    for (int j = 0; j < array2D.GetLength(1); j++)
        if (i > j) DownTr += array2D[i, j];
        else if (i < j) UpTr += array2D[i, j];
        else 
        Diag += array2D[i, j];
      
Console.WriteLine("\nСумма элементов главной диагонали = {0}", Diag);

