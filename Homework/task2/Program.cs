// Напишите программу, которая принимает на вход три числа
// и выдает макимальное из этих чисел

int a = 5;
    int b = 6;
    int c = 7;
    int FindMax = a;
      
    if (b > a)
    {
      FindMax = b;
    }
    if (c > b)
    {
      FindMax = c;
    }
    Console.WriteLine(FindMax);