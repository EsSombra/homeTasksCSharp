System.Console.WriteLine("Введите число");
double num = Convert.ToDouble(Console.ReadLine());
int count = 1;
int evenNum = 0;

System.Console.WriteLine("чётные числа от 1 до " + num + ": ");
while (count <= num)
    {
        if (count%2 == 0)
        {
            evenNum = count;
            System.Console.WriteLine(evenNum);
            count++;
        }    
        else
        {
            count++;
        }
    }

