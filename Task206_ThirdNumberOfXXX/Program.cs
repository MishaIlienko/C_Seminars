// Напишите программу, которая принимает трехзначное число 
// и на выходе показывает его последнюю цифру.
int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
bool Validate3sign(int number)
{
    if (number >= 100 && number < 1000)
    {
        return true;
    }
    System.Console.WriteLine("Число не трехзначное!");
    return false;
}
int num = ReadInt("Введите число ->");
if (Validate3sign(num))
{
    int lastDigit = num % 10;
    System.Console.WriteLine($"Последнее число {lastDigit}");

}