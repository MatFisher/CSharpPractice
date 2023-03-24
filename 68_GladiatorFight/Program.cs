// Бои гладиаторов

Random rand = new Random();
double health1 = rand.Next(90, 130);
int damage1 = rand.Next(20, 40);
int armor1 = rand.Next(40, 60);
double health2 = rand.Next(70, 150);
int damage2 = rand.Next(30, 50);
int armor2 = rand.Next(30, 50);

Console.WriteLine($"Первый гладиатор:\n\n{health1} Здоровья\n{damage1} Силы удара\n{armor1} Брони\n");
Console.WriteLine($"Второй гладиатор:\n\n{health2} Здоровья\n{damage2} Силы удара\n{armor2} Брони\n");
Console.WriteLine("Нажимайте пробел для удара\n");

while (health1 > 0 && health2 > 0) 
{
    Console.ReadKey();
    double kick2 = Math.Round(Convert.ToSingle(rand.Next(0, damage2)) / 100 * (100 - armor1), 0);
    Console.WriteLine($"Первый гладиатор получил {kick2} урона. Осталось {health1 -= kick2} здоровья.\n");
    Console.ReadKey();
    double kick1 = Math.Round(Convert.ToSingle(rand.Next(0, damage1)) / 100 * (100 - armor2), 0);
    Console.WriteLine($"Второй гладиатор получил {kick1} урона. Осталось {health2 -= kick1} здоровья.\n");
}
Console.WriteLine(); 
if (health1 <= 0 && health2 <= 0) Console.WriteLine("Ничья, оба мертвы");
else if (health1 <= 0) Console.WriteLine("Первый гладиатор пал");
else if (health2 <= 0) Console.WriteLine("Второй гладиатор пал");
Console.ReadKey();
