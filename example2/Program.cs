Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

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
