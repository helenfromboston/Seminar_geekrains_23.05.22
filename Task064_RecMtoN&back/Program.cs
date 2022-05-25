// Задача 64: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 5, 6, 7, 8"
// И наоборот, если M больше N.

void Rec(int M, int N)
{
    if (M > N)
    {
        return;
    }
    Console.Write(M + " ");
    Rec(M + 1, N);
}

void RecBack(int M, int N)
{
    if (M < N)
    {
        return;
    }
    Console.Write(M + " ");
    RecBack(M - 1, N);
}

Console.WriteLine("Введите M и N: ");
int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

if (M < N) Rec(M, N);
else RecBack(M, N);