// Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 5 && number < 8) Console.WriteLine("Выходной");
else Console.WriteLine("Не выходной");
Console.ReadKey();  