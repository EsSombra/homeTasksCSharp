//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число");
double num1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2)
{
    System.Console.WriteLine("Большее число " + num1 + ", меньшее число " + num2);
}
if (num1 == num2)
{
    System.Console.WriteLine("Числа равны");
}
else
{
    System.Console.WriteLine("Большее число " + num2 + ", меньшее число " + num1);
}
