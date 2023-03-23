// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int secondDigit = (number % 100) / 10;
    Console.Write($"Вторая цифра = {secondDigit}");
}
else Console.WriteLine("Введите корректное число");
Console.ReadKey();