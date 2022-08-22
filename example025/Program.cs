// 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Enter first number");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int numB = Convert.ToInt32(Console.ReadLine());
int ToGrade (int num1, int num2)
{
    int grade = num1;
    for (int count = 1; count < num2; count++) grade *= num1;
    return grade;
}
 Console.WriteLine($"Number {numA} in grade {numB} is {ToGrade(numA,numB)}");
