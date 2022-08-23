// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

Console.WriteLine("Enter an array size, please:");
double[] list = new double[Convert.ToInt32(Console.ReadLine())];
int size = list.Length;
int min = 0;
int max = 0;
for (int i = 0; i < size; i++)
{
    list[i] = Math.Round(new Random().NextDouble(),3);
    if (list[i] < 1) list[i] = Math.Round(list[i]*10,3);
    Console.Write(list[i] + "; ");
    if (list[i] < list[min]) min = i;
    if (list[i] > list[max]) max = i;
}
double diff = Math.Round(list[max] - list[min],3);
Console.WriteLine($"the difference between {list[max]} and {list[min]} is {diff}");