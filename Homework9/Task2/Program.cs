// Задача 66: Напишите программу, которая реализует рекурсивный метод нахождения 
// суммы натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


using static System.Console;
Clear();

Write("Введите первое число: ");
int M = Convert.ToInt32(ReadLine()!);
Write("Введите второе число: ");
int N = Convert.ToInt32(ReadLine()!);

SumMToN(M, N);

void SumMToN(int m, int n)
{
    Write(Sum(m - 1, n));
}

int Sum(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + Sum(m, n);
        return res;
    }
}