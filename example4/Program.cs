System.Console.WriteLine("Введите первое число");
double num1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
double num2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
double num3 = Convert.ToDouble(Console.ReadLine());
double max = 0;

if (num1>num2)
{
    max = num1;
}
if (num2>num3)
{
    max = num2;
}
if (num3>num1)
{
    max = num3;
}
System.Console.WriteLine("Большее число " + max);