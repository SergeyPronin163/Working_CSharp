// Напишите программу, которая на вход принимает целое число N,
// а на выходе показывает все целые числа в промежутке от -N до N.

int first = 5;
int second = -first;

while(second<=first)
{
    Console.Write(second+" ");
    second++;
}