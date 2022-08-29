// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Enter number of rows:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns:");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] GetArray(int m, int n)
{
    double[,] matrix = new double [m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] = Math.Round(new Random().NextDouble()*100,3);
        }
    }
    return matrix;
}

double [,] array = GetArray(rows,columns);
PrintArray(array);

void PrintArray(double [,] inputMatrix)
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