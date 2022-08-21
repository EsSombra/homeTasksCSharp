// 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Enter first number");
double numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
double numB = Convert.ToInt32(Console.ReadLine());
double ToGrade (double num1, double num2)
{
    double grade = numA;
    for (double count = 1; count < numB; count++) grade *= numA;
    if (numA > 0 && numB < 0) 
    {
        for(double count = -1; count > numB; count--) grade *= numA; grade = 1 / grade;
    } 
    if (numA < 0 && numB < 0)
    {
        if (numB % 2 != 0)
        {
           for(double count = -1; count > numB; count--) grade *= numA; grade = 1 / grade;  
        }
        else 
        {
            for(double count = -1; count > numB; count--) grade *= numA; grade = -1 / grade;
        }
    }
    return grade;
}
if (numA != 0 && numB == 0) Console.WriteLine($"Number {numA} in grade {numB} is 1"); 
else 
    Console.WriteLine($"Number {numA} in grade {numB} is {ToGrade(numA,numB)}");
