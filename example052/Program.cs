// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] GetArray(int m, int n)
{
    int [,] matrix = new int [m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] = new Random().Next(10);
        }
    }
    return matrix;
}

int [,] array = GetArray(4,4);
PrintArray(array);

void PrintArray(int [,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Arithmetic means of columns are:");
ArithmeticMean(array);
void ArithmeticMean (int[,] matrix)
{
    int row = 0, column = 0;
    double sum = 0;
    int sizeRows = matrix.GetLength(0) - 1;
    int sizeCol = matrix.GetLength (1) - 1; 
    while (column <= sizeCol)
    {
        while (row <= sizeRows)
        {
            sum += matrix[row,column]; 
            row++;
        }
        double result = sum/matrix.GetLength(0);
        Console.Write(result + "\t");
        sum = 0;
        row = 0;
        column++;
    }
}
