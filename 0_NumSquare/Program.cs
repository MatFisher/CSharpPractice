// Вывести квадрат числа

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
number *= number;
Console.Write($"Квадрат числа = {number}");
Console.ReadKey();