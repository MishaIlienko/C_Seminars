//На ввод принимаем числа от 1-7, на вовод даем название дня недели
Console.WriteLine("Введите число для поиска дня недели!");
string [] week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
string weekday = Console.ReadLine();
int day = Convert.ToInt32(weekday);
Console.WriteLine(week[day -1]);







//На ввод принимаем числа от 1-7, на вовод даем название дня недели
Console.WriteLine("Введите пожалуйста число!");
string inputedString = Console.ReadLine();
int day = Convert.ToInt32(inputedString);

    if(day == 1)
    {
        Console.WriteLine("Это Понедельник!");
    }
    if(day == 2)
    {
        Console.WriteLine("Это Вторник!");
    }
    if(day == 3)
    {
        Console.WriteLine("Это Среда!");
    }
    if(day == 4)
    {
        Console.WriteLine("Это Четверг!");
    }
    if(day == 5)
    {
        Console.WriteLine("Это Пятница!");
    }
    if(day == 6)
    {
        Console.WriteLine("Это Суббота!");
    }
    if(day == 7)
    {
        Console.WriteLine("Это Воскресенье!");
    }
 
   if(day > 7)
{
    Console.WriteLine("Под этой нумерацией дня нет!");
}
if(day < 1)
{
    Console.WriteLine("Под этой нумерацией дня нет!");
}