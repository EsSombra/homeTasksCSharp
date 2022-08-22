// 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Enter number");
string? num = Console.ReadLine();

int SumDigits (string? number)
{
    int sum = 0;
    int test = 0;
    for (int i = 0; i < number.Length; i++)
    {    
        test = int.Parse(number[i].ToString());
        sum+=test;
    }
    return sum;
}
Console.WriteLine($"Sum of digits {num} is {SumDigits(num)}");
