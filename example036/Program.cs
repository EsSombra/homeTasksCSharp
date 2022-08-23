// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Enter array size, please:");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
int size = array.Length;
int sum = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-100, 101);
    Console.Write(array[i] + "; ");
}

for (int i = 1; i < size; i += 2)
{
    sum += array[i];
}
Console.WriteLine($"Sum of elements with negative indexes is {sum}");