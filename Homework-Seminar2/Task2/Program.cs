// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠0 
// и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

double x = 0;
 
double y = 0;
 

if (x > 0 && y > 0)
    Console.WriteLine("I четверть");
else if (x < 0 && y > 0)
    Console.WriteLine("II четверть");
else if (x < 0 && y < 0)
    Console.WriteLine("III четверть");
else if (x > 0 && y < 0)
    Console.WriteLine("IV четверть");
else if (x == 0 || y == 0)
    Console.WriteLine("Точка является началом координат или лежит на одной из осей x или y");


// Другой вариант:

// if (x > 0)
// {
// if (y > 0)
// Console.WriteLine("I четверть");

// else if (y < 0)
// Console.WriteLine("IV четверть");
// }
// else if (x < 0)
// {
// if (y > 0)
// Console.WriteLine("II четверть");
// else if (y < 0)
// Console.WriteLine("III четверть");
// }
// else
// {
// Console.WriteLine("Точка является началом координат или лежит на одной из осей x или y")
// }