using static System.Console;
Clear();

WriteLine("Введите цифру, обозначающую день недели: ");
int a = int.Parse(ReadLine()!);

WriteLine(a > 0 && a < 6 ? "нет" : (a==6 || a ==7) ? "да" : "Введено неверное число");
