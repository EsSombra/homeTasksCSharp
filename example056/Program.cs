// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int[,] array = GetMatrixRndInt(4, 3, 0, 9);

PrintMatrix(array);

Console.WriteLine();

MinSumRows(array);

void MinSumRows (int[,] matrix)
{
    int row = 0;
    int col = 0;
    int sum = 0;
    int minSum = int.MaxValue;
    int minRow = row;
    while (row < matrix.GetLength(0))
    {
        while (col < matrix.GetLength(1))
        {
            sum += matrix[row,col];
            col++;
        }
        Console.WriteLine($"Sum of elements row {row} is {sum}");
        if (sum < minSum)
        { 
            minSum = sum; 
            minRow = row;
        } 
        sum = 0;
        col = 0;
        row++;
    }
    Console.WriteLine($"Number of row with minimal sum of elements is {minRow}");
}
