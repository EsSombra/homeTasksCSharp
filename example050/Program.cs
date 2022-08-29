// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.WriteLine("Enter row number:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter column number:");
int column = Convert.ToInt32(Console.ReadLine());
int result = 0;

int [,] GetArray(int m, int n)
{
    int [,] matrix = new int [m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] = new Random().Next(20);
        }
    }
    return matrix;
}

int [,] array = GetArray(5,4);
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

for (int i = 0; i < array.GetLength(0); i++)
{   
    for (int j = 0; j < array.GetLength(1); j++)
    {
     if (row == i && column == j) result = array[i,j];
    }
}
if (result != 0) Console.WriteLine($"Requested value is {result}");
else Console.WriteLine("There is NO requested element here");