// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Enter number M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number N");
int numN = Convert.ToInt32(Console.ReadLine());

if (numM > numN) 
{
    Console.WriteLine("First number must be less then second!");
    return;
}

string PrintNumbers (int M, int N)
{
    if (M == N) return M.ToString();
    return (M + ", " + PrintNumbers(M+1,N));
}
Console.WriteLine($"Numbers from {numM} to {numN} is: {PrintNumbers(numM,numN)}");

int SumElements (int M, int N)
{
    if (M == N-1) return 0;
    return ((M+1) + SumElements(M+1,N));
}
Console.WriteLine($"Sum of numbers between {numM} and {numN} is: {SumElements(numM,numN)}");