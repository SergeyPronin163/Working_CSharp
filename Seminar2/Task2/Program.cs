// Напишите программу, которая принимает на вход трехзначное число 
// и возводит цифру этого числа в степень, равную третьей цифре.

// Примеры

// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

int num = 123;
int second = num/10%10;
int third = num%10;
int count = 1;
int sum = second;

while (count<third)
{
sum *= second; // sum = sum * second
    count++;
}
Console.Write(sum);