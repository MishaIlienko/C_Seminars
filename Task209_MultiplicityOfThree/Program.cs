// Напишите программу, которая принимает на вход число 
//и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

int number(string message)
{
    System.Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int a = 7;
int b = 23;
int input = number("Введите ваше число -> ");
if (input % a == 0 && input % b == 0)
{
    System.Console.WriteLine($"Ваше число кратно одновременно {a} и {b}!");
}
else
{
    System.Console.WriteLine($"Ваше число НЕ кратно одновременно {a} и {b}!");
}