//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите число");
int day = Convert.ToInt32(Console.ReadLine());
int dayOff1 = 6, dayOff2 = 7, daysPerWeek = 7; // магическим числам - бой!)
if (day == dayOff1 || day == dayOff2) System.Console.WriteLine($"Ура! {day} день недели - выходной!");
if (day <= daysPerWeek && day != dayOff1 && day != dayOff2) System.Console.WriteLine($"{day} недели - рабочий...");
if (day > daysPerWeek) System.Console.WriteLine("Такого дня недели нет.");
