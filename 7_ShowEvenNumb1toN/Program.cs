// Показать четные числа от 1 до N

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) for (int count = 2; count <= number; count += 2) Console.Write($"{count} ");
else Console.WriteLine("Введено не натуральное число");
Console.ReadKey();