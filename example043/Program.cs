// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Enter first parameter k1 of the line:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second parameter b1 of the line:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter first parameter k2 of the line2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second parameter b2 of the line2:");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = (b1 - b2)/(k2 - k1);
double y = (b1*k2 - b2*k1)/(k2-k1);  
Console.WriteLine($"The intersection point is ({x};{y})");