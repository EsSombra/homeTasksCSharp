// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Enter a number");
string num = Console.ReadLine();
int size = num.Length;
// if (size != 5) System.Console.WriteLine("Sorry, a number isn't five-digit");
// if (num[0] != num[4] && size == 5) System.Console.WriteLine($"{num} isn't a palindrome");
// if (num[0] == num[4] && num[1] == num[3]) System.Console.WriteLine($"{num} is a palindrome");


// В палиндроме хватит 3 проверок:
// 1. размер числа (5 ли элементов)
// 2. 0 элемент по индексу == 4 и 1 == 3
// 3. если не равен, то палиндром
// "if (num[0] != num[4] && size == 5) System.Console.WriteLine($"{num} isn't a palindrome""; - отсылка на эту строчку.


if (size != 5) Console.WriteLine("Sorry, a number isn't five-digit");
if (size == 5) if (num[0] == num[4] && num[1] == num[3]) System.Console.WriteLine($"{num} is a palindrome");
    else Console.WriteLine($"{num} isn't a palindrome");

