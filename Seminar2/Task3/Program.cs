﻿// Напишите программу, которая будет принимать на вход 2 числа и выводить,
// является ли второе число кратным первому. Если второе число некратно первому,
// то программа выводит остаток от деления.

// Примеры

// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

Console.Clear(); // Очищение консоли,перед запуском
int num1 = 16;
int num2 = 8;

if(num1%num2 == 0)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет, " + num1%num2);
}