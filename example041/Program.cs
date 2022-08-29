// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("How much numbers want you check?");
int quantity = Convert.ToInt32(Console.ReadLine());
int[] nums = GetArray(quantity);
int size = nums.Length;
int count = 0;

for (int i = 0; i < size; i++)
{
    if(nums[i] > 0) count++;
}
Console.WriteLine($"Count of positive numbers is: {count}");

int[] GetArray (int M) 
{
    int[] numbers = new int [M];
    int size = M;
    Console.WriteLine($"Please, enter {M} numbers." );
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Enter one:");
        int num = Convert.ToInt32(Console.ReadLine());
        numbers[i] = num;
    }
    return numbers;
}



// Console.WriteLine("Enter number:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter stop if you want to stop");
// int stop = int.Parse(Console.ReadLine());
// int count = 0;
// while (num == stop)
// {
//     if (num > 0) count++;
//     Console.WriteLine("Enter number:");
//     num = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Count of positive numbers is: {count}");