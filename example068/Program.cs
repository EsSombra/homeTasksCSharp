// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Enter number M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number N");
int numN = Convert.ToInt32(Console.ReadLine());

if (numM < 0 || numN < 0) 
{
    Console.WriteLine("The numbers must be 0 or positive only!");
    return;
}

int Ackermann (int M, int N)
{
    if (M == 0) return (N+1);
    if (M > 0 && N == 0) return Ackermann(M-1,1);
    return Ackermann(M-1,Ackermann(M,N-1));
}
Console.WriteLine($"The value of the Ackermann function of ({numM},{numN}) is {Ackermann(numM,numN)}");

