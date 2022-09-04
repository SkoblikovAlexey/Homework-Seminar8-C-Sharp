// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


bool FindElement(int[,,] array, int elem)
{
    bool check = true;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (elem == array[i, j, k]) check = true;
                else check = false;
            }
        }
    }
    return check;
}


int[,,] CreateArray(int m, int n, int l)
{
    int[,,] array = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                int element = new Random().Next(1, 9);
                if (FindElement(array, element)) continue;
                array [i, j, k] = element;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

Console.WriteLine("ВВедите длину массива.");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите ширину массива.");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите высоту массива.");
int z = Convert.ToInt32(Console.ReadLine());
PrintArray(CreateArray(x, y, z));
