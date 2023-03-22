// Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Multiple(number) ? "да" : "нет");

bool Multiple(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

Console.ReadKey();