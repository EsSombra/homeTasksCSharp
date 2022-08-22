// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] FillArray (int num)
{
    int[] array = new int [num];
    for (int i = 0; i < num; i++)
    {
        System.Console.WriteLine("Enter number");
       array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
Console.WriteLine($"Result is: [{string.Join("; ", FillArray(8))}]");