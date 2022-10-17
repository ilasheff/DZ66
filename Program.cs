/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N*/

Console.WriteLine("Введите начальное число M:");
int num_M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число M:");
int num_N = Convert.ToInt32(Console.ReadLine());

void GapNumberSum (int num_M, int num_N, int sum)
{
    if (num_M > num_N) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (num_M++);
    GapNumberSum(num_M, num_N, sum);
}

GapNumberSum(num_M, num_N, 0);