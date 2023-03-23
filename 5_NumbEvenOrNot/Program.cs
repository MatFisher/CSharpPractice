// Выяснить является ли число чётным

Console.WriteLine("Введите число");
int numA = Convert.ToInt32(Console.ReadLine());

if (numA % 2 == 0) Console.WriteLine("Число четное");
else Console.WriteLine("Число нечетное");
Console.ReadKey();