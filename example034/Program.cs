// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

int [] list = new int [13];
int size = list.Length;
int count = 0;
for (int i = 0; i < size; i++)
{
    list [i] = new Random().Next(100,1000);
    if (list [i] %2 == 0) count++;
}
Console.WriteLine($"Count of even numbers of [{string.Join("; ", list)}] is {count}");
