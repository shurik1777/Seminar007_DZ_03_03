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
/*
Console.WriteLine("Сумма побочной диагонали:");
EnterUsEl = new int[n, m];
int sum = 0;
for (int i = n - 1; i >= 0; --i) {
    for (int j = m - 1; j >= 0; --j) {
        if (i == j)
            sum += array[i, j];
    }
}

int[,] array2D = GetMatrix(3, 4, 1, 9);
PrintMatrix(array2D);

int[] arrElem = EnterUsEl("Введите позицию элемента в двумерном массиве (строки и столбца через Enter): ");
*/
Console.WriteLine("Введите количество строк:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, m];
            Console.WriteLine("Вводите числа:");
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Сумма побочной диагонали:");
            int sum = 0;
            for (int i = n-1; i >= 0; --i)
            {
                for (int j = m-1; j >= 0; --j)
                {
                    sum += array[i, j];
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
