using static System.Console;
Clear();

WriteLine("Введите число от 100 до 999: ");
int a = int.Parse(ReadLine()!);

if (a > 99 && a < 1000)
    {
    WriteLine($"Вторая цифра числа {a} равна {a / 10 % 10}");
    }
else
    {
    WriteLine("Введено неверное число");
    }

