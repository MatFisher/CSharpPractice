// Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введите пятизначное число");
int numberA = Convert.ToInt32(Console.ReadLine());
string Palindrom(int num)
{
    if (num % 100000 / 10000 == num % 10 && num % 10000 / 1000 == num % 100 / 10) return "Палиндром";
    else return "Не палиндром";
}

if (numberA.ToString().Length == 5)
{
    string result = Palindrom(numberA);
    Console.WriteLine(result);
}
else Console.WriteLine("Число не является пятизначным");
Console.ReadKey();