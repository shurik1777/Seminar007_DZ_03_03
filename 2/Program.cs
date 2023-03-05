/*
Задача 50. Напишите программу, которая на вход принимает
позиции элемента в двумерном массиве, и возвращает значение
этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4
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
// Запрос ввода от пользователя
int[] EnterUsEl(string text)
{
    Console.WriteLine(text);
    int i = Convert.ToInt32(Console.ReadLine());
    int j = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[]{i,j};
    return array;
}
// Вывод позиции массива в формате (индекс строки, индекс столбца) на печать
void PrintArray(int[] array)
{
    Console.Write("( ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write(array[i] + ",");
        else
            Console.Write(array[i]);
    }
    Console.Write(" )");
}
// Проверка, что такая позиция в двумерном массиве есть
bool CheckCorPosition(int[,] matrix, int[] array)
{
    return (matrix.GetLength(0) > array[0] && matrix.GetLength(1) > array[1]) && array[0] >= 0 && array[1] >= 0;
}
// Получаем по заданной позиции элемента значение в двумерном массиве
int GetValueFromMatrix(int[,] matrix, int[] array)
{
    int value = matrix[array[0], array[1]];
    return value;
}

int[,] array2D = GetMatrix(3, 4, 1, 9);
PrintMatrix(array2D);

int[] arrElem = EnterUsEl("Введите позицию элемента в двумерном массиве (строки и столбца через Enter): ");

if (!CheckCorPosition(array2D, arrElem))
{
    PrintArray(arrElem);
    Console.Write(" Увы и ах такого элемента в массиве нет");
}
else
{
    int elementValue = GetValueFromMatrix(array2D, arrElem);
    Console.Write("Значение элемента индекса в двумерном массиве на позиции ");
    PrintArray(arrElem);
    Console.Write($" равно: {elementValue}");
}