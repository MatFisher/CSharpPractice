// Показать числа от -N до N

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) for (int count = -number; count <= number; count++) Console.Write($"{count} ");
else Console.WriteLine("Введено не натуральное число");
Console.ReadKey();