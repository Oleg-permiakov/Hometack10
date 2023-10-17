// Принимает на вход трёхзначное число, на выходе показывает вторую цифру
Console.WriteLine("Введите трёхзначное число");
string namb = Console.ReadLine();
int namber = Convert.ToInt32(namb);

int a = namber / 10 % 10;
Console.WriteLine(a);
