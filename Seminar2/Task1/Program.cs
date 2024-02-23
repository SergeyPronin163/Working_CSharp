// Напишите пограмму, которая принимает на вход
// трехзначное число и удаляет вторую цифу этого числа.

int num = 123;
int first = num/100;
int second = num%10;
Console.Write("Numb without second dight is - " + first+second);