// Напишите программу, которая будет принимать на вход два числа и 
//выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

int number1(string message)
{
    System.Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
int number2 (string message1)
{
    System.Console.Write(message1);
    int input1 = Convert.ToInt32(Console.ReadLine());
    return input1;
}
int a = number1("Введите первое число! -> ");
int b = number2 ("Введите второе число! -> ");
if (a % b == 0)
{
    System.Console.WriteLine("Второе число кратное первому!");
}
else
{
    System.Console.WriteLine($"Остаток -> {a % b}");
}
