// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = { {1, 4, 7, 2},
                  {5, 9, 2, 3},
                  {8, 4, 2, 4},
                  {5, 2, 6, 7}};

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int MinSumRow(int[,] matrix)
{
    int indexMinSumRow = 1;
    int[] sumRowArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        sumRowArray[i] = sumRow;        
    }
    int minSumRow = sumRowArray[0];
    for (int i = 0; i < sumRowArray.Length; i++)
    {
        if (sumRowArray[i] < minSumRow)
        {
            minSumRow = sumRowArray[i];
            indexMinSumRow = (i + 1);
        }
    }
    return indexMinSumRow;
}

PrintMatrix(matrix);
Console.WriteLine($"Строка {MinSumRow(matrix)} имеет минимальную сумму элементов.");
