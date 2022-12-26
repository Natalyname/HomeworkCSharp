using static System.Console;
Clear();

WriteLine("Введиты координвты точки А: ");
Write("x = ");
int.TryParse(ReadLine(), out int ax);
Write("y = ");
int.TryParse(ReadLine(), out int ay);
Write("z = ");
int.TryParse(ReadLine(), out int az);
WriteLine("Введите координаты точки B: ");
Write("x = ");
int.TryParse(ReadLine(), out int bx);
Write("y = ");
int.TryParse(ReadLine(), out int by);
Write("z = ");
int.TryParse(ReadLine(), out int bz);

double s=Math.Sqrt(((bx-ax)*(bx-ax))+((by-ay)*(by-ay))+((bz-az)*(bz-az)));
WriteLine($"{s:f2}");

