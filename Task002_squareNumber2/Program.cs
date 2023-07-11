//На ввод принимаем два числа и проверяем второе число квадратом первого
Console.WriteLine("Введите первое число");
string inputedString1 = Console.ReadLine();
int number1 = Convert.ToInt32(inputedString1);
Console.WriteLine("Введите второе число");
string inputedString2 = Console.ReadLine();
int number2 = Convert.ToInt32(inputedString2);
//int square = number1 * number1;
//if (square == number2)
if(number2 == number1*number1)
{
    Console.WriteLine($"Число {number2} является квадратом от {number1}!");
}
    else 
    {
    Console.WriteLine($"Число {number2} не является квадратом от {number1}!");
    }



