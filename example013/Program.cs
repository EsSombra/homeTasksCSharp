//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите число");
string num = Console.ReadLine();
int size = num.Length;
int index = 0;
int third = 2;
if (size < 3) System.Console.WriteLine("В заданном числе отсутствует третья цифра");
else
{
    while (index < size) 
    {
        if (index == third) System.Console.WriteLine($"Третья цифра числа {num} - {num[index]}");
        index++;
    }
}

