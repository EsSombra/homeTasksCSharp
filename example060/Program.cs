// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GetArrayRndInt(int row, int col, int z, int min, int max)
{
    Random rnd = new Random();
    int[,,] matrix = new int[row, col, z];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(2); n++)
            {
                matrix[i, j, n] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(2); n++)
            {
                Console.Write($"{matrix[i, j, n], 3}");
            }
            System.Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] array3d = GetArrayRndInt(3, 5, 4, 0, 31);

PrintMatrix(array3d);

