// Напишите программу, которая выводит случайное число [10, 9999]
//и показывает наибольшую цифру

int number = new Random().Next(10, 10000);
int num1 = 0;
int num2 = 0;
System.Console.WriteLine($"Из числа {number} наибольшая цифра -> ");
while (number > 0)
{
    num1 = number % 10;
    if (num1 > num2)
    {
        num2 = num1;
    }
    number /= 10;
}
System.Console.WriteLine(num2);