//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Нужно сделать через числа, без индексов строк.

System.Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000) {int result = (num / 10) % 10; System.Console.WriteLine($"Вторая цифра числа {num} - это {result}");}
else System.Console.WriteLine("Ошибка. Введено неверное число");
