// Напишите программу, которая принимает на вход трёхзначное целое число и на 
// выходе показывает сумму первой и последней цифры этого числа.

int num = 123;
int first = num / 100;
int last = num % 10;
int sum = first + last;
Console.Write("Sum of first and last digit is - " + sum);