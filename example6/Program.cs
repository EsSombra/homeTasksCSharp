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
