// Найти расстояние между точками в пространстве 3D

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int xPointA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yPointA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zPointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int xPointB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yPointB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zPointB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xPointA, yPointA, zPointA, xPointB, yPointB, zPointB);
Console.WriteLine($"Расстояние между точками равно: {Math.Round(distance, 2, MidpointRounding.ToZero)}");
double Distance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt(Math.Pow(xA-xB, 2)+Math.Pow(yA-yB, 2) + Math.Pow(zA - zB, 2));
}

Console.ReadKey();