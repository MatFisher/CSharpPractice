// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
if (number >= 100 && number <= 999) Console.WriteLine($"Последняя цифра = {number %= 10}");
else Console.WriteLine("Введено некорректное число");
Console.ReadKey();