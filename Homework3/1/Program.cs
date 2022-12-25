using static System.Console;
Clear();

WriteLine("Введите пятизначное число: ");
int n = int.Parse(ReadLine()!);

WriteLine((n > 99999 || n < 10000)? "Число не пятизначное" : n%10==n/10000 && n/1000%10==n/10%10 ? "Число является палиндромом" : "Число не является палиндромом");
