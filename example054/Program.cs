// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GetMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine();
    }
}

int[,] array = GetMatrixRndInt(4, 4, 0, 9);

PrintMatrix(array);
Console.WriteLine();
SortRows (array);


void SortRows(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        var stop = false;

        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            for (int k = 0; k < matrix.GetLength(1)-1-j; k++)
            {
                if (matrix[i, k] > matrix[i, k + 1])
                {
                    int tmp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = tmp;
                    stop = true;
                }
                if (!stop) break;
            }
        }
            
    }
    int r = matrix.GetLength(0);
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < r; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.ReadKey();
}



