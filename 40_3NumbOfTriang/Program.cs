// Выяснить являются ли три числа сторонами треугольника 

Console.WriteLine("Введите сторону А");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону B");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону C");
int numC = Convert.ToInt32(Console.ReadLine());

string Pifagor(int a, int b, int c)
{
    if (c < a+b && a < c+b && b < a+c) return "Да";
    else return "Нет";
}

string result = Pifagor(numA, numB, numC);
Console.WriteLine(result);
Console.ReadKey();