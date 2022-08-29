// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());
int[] binaryNum = new int [num];

for (int i = 0; num == 0; i++) 
{
    int remains = num/2;
    int result = num%2;
    num = remains;
    binaryNum[i] = result; 
} 
// binaryNum = Array.Reverse(binaryNum);

Console.WriteLine($"{num} in binary notation is: {string.Join("",binaryNum)}");


