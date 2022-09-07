// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Enter first number");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
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