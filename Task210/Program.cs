// Напишите программу, которая выводит случайное число [10, 9999]
//и показывает наибольшую цифру

int number = new Random().Next(10, 10000);
int rest10 = 0;
int max = 0;
System.Console.WriteLine($"Из числа {number} наибольшая цифра -> ");
while (number > 0)
{
    rest10 = number % 10;
    if (rest10 > max)
    {
        max = rest10;
    }
    number /= 10;
}
System.Console.WriteLine(max);