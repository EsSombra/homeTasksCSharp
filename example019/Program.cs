// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Enter a number");
string num = Console.ReadLine();
int size = num.Length;
if (size != 5) System.Console.WriteLine("Sorry, a number isn't five-digit");
if (num[0] != num[4] && size == 5) System.Console.WriteLine($"{num} isn't a palindrome");
if (num[0] == num[4] && num[1] == num[3]) System.Console.WriteLine($"{num} is a palindrome");

