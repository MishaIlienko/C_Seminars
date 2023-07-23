// Напишите программу, которая выводит случайное число [10, 9999]
//и показывает наибольшую цифру

int number = new Random().Next(10, 10000);
int a = number % 10;
int b = number / 10 % 10;
int c = number / 100 % 10;
int d = number / 1000;
int max = 0;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
System.Console.WriteLine($"В числе {number} максимальная цифра {max}!");