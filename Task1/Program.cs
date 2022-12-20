using static System.Console;
Clear();

WriteLine("Введите число от 100 до 999: ");
int a = int.Parse(ReadLine()!);
int b = (a % 100);

WriteLine($"Вторая цифра числа {a} равна {b / 10}");
