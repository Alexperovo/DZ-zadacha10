// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write ("введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num / 100;
int num2 = num % 100 / 10;
 Console.Write (num2);