//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
System.Console.WriteLine("Для проверки на чётность введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
if (num%2 == 0)
{
    System.Console.WriteLine(num + " является чётным");
}
else
{
    System.Console.WriteLine(num + " является нечётным");
}
