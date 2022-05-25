// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120 // M = 4; N = 8 -> 30

int sum = 0;

void RecSum(int M, int N)
{
    if (M > N)
    {
        return;
    }
    sum += M;
    RecSum(M + 1, N);
}

RecSum(1, 15);
Console.WriteLine(sum);