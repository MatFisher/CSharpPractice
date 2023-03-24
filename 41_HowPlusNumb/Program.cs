// Определить сколько чисел больше 0 введено с клавиатуры

Console.WriteLine("Введите планируемое количество чисел для ввода");
int howMuch = Convert.ToInt32(Console.ReadLine());

int[] EnterArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int HowBigger0(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > 0) result++;
    return result;
}

int[] ar = EnterArray(howMuch);
int count = HowBigger0(ar);
Console.WriteLine($"Введено чисел больше 0 - {count}");
Console.ReadKey();
