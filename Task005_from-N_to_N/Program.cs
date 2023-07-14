// Напишите программу, которая принимает одно число (N), а на выходе 
//показывает все целые числа в промежутке от -N до N.
Console.WriteLine("Введите число");
string input = Console.ReadLine();
int num = Convert.ToInt32(input);
int num1 = -num;
while(num1 <= num)
{
    Console.Write(num1);
    num1++;
}
