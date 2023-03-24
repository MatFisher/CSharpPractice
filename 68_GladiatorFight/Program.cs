// Бои гладиаторов

Random rand = new Random();
double health1 = rand.Next(90, 130);
int damage1 = rand.Next(20, 40);
int armor1 = rand.Next(40, 60);
double health2 = rand.Next(70, 150);
int damage2 = rand.Next(30, 50);
int armor2 = rand.Next(30, 50);

Console.WriteLine("Первый гладиатор: ");
Console.WriteLine();
Console.WriteLine(+health1 + " Здоровья ");
Console.WriteLine(+ damage1 + " Силы удара ");
Console.WriteLine(+ armor1 + " Брони");
Console.WriteLine();
Console.WriteLine("Второй гладиатор: ");
Console.WriteLine();
Console.WriteLine(+health2 + " Здоровья ");
Console.WriteLine( + damage2 + " Силы удара ");
Console.WriteLine(+armor2 + " Брони");
Console.WriteLine();
Console.WriteLine("Нажимайте пробел для удара");

while (health1 > 0 && health2 > 0) 
{
    Console.ReadKey();
    double kick2 = Math.Round(Convert.ToSingle(rand.Next(0, damage2)) / 100 * (100 - armor1), 0);
    health1 -= kick2;
    Console.WriteLine("Первый гладиатор получил " + kick2 + " урона. Осталось " + health1 + " здоровья.");
    Console.ReadKey();
    double kick1 = Math.Round(Convert.ToSingle(rand.Next(0, damage1)) / 100 * (100 - armor2), 0);
    health2 -= kick1;
    Console.WriteLine("Второй гладиатор получил " + kick1 + " урона. Осталось " + health2 + " здоровья.");
}
Console.WriteLine(); 
if (health1 <= 0 && health2 <= 0) Console.WriteLine("Ничья, оба мертвы");
else if (health1 <= 0) Console.WriteLine("Первый гладиатор пал");
else if (health2 <= 0) Console.WriteLine("Второй гладиатор пал");
Console.ReadKey();
