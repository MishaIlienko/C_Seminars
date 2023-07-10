// Напишите програму, которая на взод принимает число
// и выдает его квадрат (число умноженное на само себя)

Console.Write("Введите число => "); //Вывод в консоль приглашения.
string inputedString = Console.ReadLine ();//Ввод пользователя (строка).
int number = Convert.ToInt32(inputedString);//Преоброазования строки в число. 
Console.WriteLine($"Вы ввели число {number}!");//Вывод введенного значения.
int square = number * number;//Логика программы. 
Console.WriteLine($"Квадрат числа {number} равен {square}!");//Вывод результата.