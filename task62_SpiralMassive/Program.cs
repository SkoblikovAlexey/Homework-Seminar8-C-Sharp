// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillArray(int[,] array)
{
    int i = 0;
    int j = 0;
    int num = 1;
    for (int k = 0; k < array.GetLength(0) * array.GetLength(1); k++)
    {
        array[i, j] = num;
        if (i <= j + 1 && i + j < array.GetLength(0) - 1)
        j++;
        else if(i < j && i + j >= array.GetLength(1) - 1)
        i++;
        else if(i >=j && i + j > array.GetLength(0) - 1)
        j--;
        else i--;
        num++;
    }
    
}
void PrintArray(int[,] matrix)
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

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);