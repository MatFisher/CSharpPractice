// Игра Pac-Man

int pacmanX, pacmanY;
int pacmanDX = 0, pacmanDY = 1;
bool isPlaying = true;
Console.CursorVisible = false;


char[,] map = ReadMap("Map1", out pacmanX, out pacmanY);


PrintMap(map);

while (isPlaying)
{
    DrawPlayer(pacmanY, pacmanX);
    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        PacmanMove(key, ref pacmanDX, ref pacmanDY);
    }
    if (map[pacmanDX + pacmanX, pacmanDY + pacmanY] != '#')
    {
        Move(ref pacmanX, ref pacmanY, pacmanDX, pacmanDY);
    }
    System.Threading.Thread.Sleep(100);
}


char[,] ReadMap(string mapName, out int pacmanX, out int pacmanY)
{
    pacmanX = 0; pacmanY = 0;
    string[] newfile = File.ReadAllLines($"Maps/{mapName}.txt");
    char[,] map = new char[newfile.Length, newfile[0].Length];

    for(int i = 0; i < map.GetLength(0); i++)
    {
        for(int j = 0; j < map.GetLength(1); j++) 
        {
            map[i,j] = newfile[i][j];
            if (map[i,j] == '@')
            {
                pacmanX = i; pacmanY = j;
            }
        }
    }
    return map;
}

void PrintMap(char[,] map)
{
    for(int i = 0; i < map.GetLength(0);i++)
    {
        for(int j = 0; j < map.GetLength(1);j++)
        {
            Console.Write(map[i,j]);
        }
        Console.WriteLine();
    }
}

void DrawPlayer(int pacmanY, int pacmanX)
{
   Console.SetCursorPosition(pacmanY, pacmanX);
    Console.Write('@');
}

void Move(ref int x, ref int y, int dx, int dy)
{
    Console.SetCursorPosition(y, x);
    Console.Write(" ");

    x += dx;
    y += dy;

    Console.SetCursorPosition(y, x);
    Console.Write("@");
}

void PacmanMove(ConsoleKeyInfo key, ref int dx, ref int dy)
{
    switch (key.Key)
    {
        case ConsoleKey.UpArrow:
            dx = -1; dy = 0;
            break;
        case ConsoleKey.DownArrow:
            dx = 1; dy = 0;
            break;
        case ConsoleKey.LeftArrow:
            dx = 0; dy = -1;
            break;
        case ConsoleKey.RightArrow:
            dx = 0; dy = 1;
            break;
    }
}