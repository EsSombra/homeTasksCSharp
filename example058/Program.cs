// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

Console.WriteLine($"First Matrix:");
int[,] firstMatrix = GetMatrixRndInt(2, 2, 0, 5);
PrintMatrix(firstMatrix);

Console.WriteLine($"Second matrix:");

int[,] secondMatrix = GetMatrixRndInt(2, 2, 2, 5);
PrintMatrix(secondMatrix);

if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0)) Console.WriteLine("Impossible to calculate the product of matrices!");
else 
{
    Console.WriteLine($"The product of matrices is:");
    PrintMatrix(ProductMatrices(firstMatrix, secondMatrix));
}


int [,] ProductMatrices (int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0),arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            result [i,j] = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                result [i,j]+= firstMatrix[i,k]*secondMatrix[k,j];
            }
        }
    }
    return result;
}
