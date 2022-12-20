using static System.Console;
Clear();

WriteLine("Введите число: ");
int num = int.Parse(ReadLine()!);

if (num > 99)
    {
    while (num/100 > 10)
    {
    num = num/10;
    }
    WriteLine($"Третья цифра - {num%10}");
    }

else
{
    WriteLine("Нет третьей цифры");
}