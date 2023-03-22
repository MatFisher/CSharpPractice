// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainsDigits;
if (number1 > number2) remainsDigits = RemainsDigits(number1, number2);
else remainsDigits = RemainsDigits(number2, number1);

    Console.WriteLine(remainsDigits == 0 ? "Кратно" : $"Не кратно, остаток -> {remainsDigits}");

int RemainsDigits(int num1, int num2)
{
    return num1 % num2;
}
Console.ReadKey();