// Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA > numB) Console.WriteLine($"Большее число = {numA}, Меньшее число = {numB}");
else Console.WriteLine($"Большее число = {numB}, Меньшее число = {numA}");
Console.ReadKey();