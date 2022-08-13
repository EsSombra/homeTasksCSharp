// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.WriteLine("Enter your number, please");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Third power of digitals from 1 to {num} are: ");
for (int count = 1; count<=num;count++)
{
    Console.Write(Math.Pow(count,3) + "\t");
}
