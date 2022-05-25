// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int m = 3;
int n = 5;
int A = 0;

int RecAck(int m, int n)
{
    if (m == 0)
    {
        return A = n + 1;
    }
    if (n == 0)
    {
        return A = RecAck(m - 1, 1);
    }
    else
    {
        return A = RecAck(m - 1, RecAck(m, n - 1));
    }
}

if (m < 0 || n < 0)
{
    Console.WriteLine("Функция Аккермана определяется только для неотрицательных целых чисел");
}
else
{
    RecAck(m, n);
    Console.WriteLine(A);
}