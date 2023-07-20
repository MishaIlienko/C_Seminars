//Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

int num = new Random().Next(10, 99);
int num1 = num % 10;
int num2 = num / 10;
if (num1 > num2)
{
    System.Console.WriteLine($"В числе {num} наибольшая цифра {num1}!");
}
if (num2 > num1)
{
    System.Console.WriteLine($"В числе {num} наибольшая цифра {num2}!");
}
if (num1 == num2)
{
    System.Console.WriteLine($"В числе {num} обе цифры равны!");
}



