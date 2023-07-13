//На ввод принимаем числа от 1-7, на вовод даем название дня недели
Console.WriteLine("Введите число для поиска дня недели!");
string [] week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
string weekday = Console.ReadLine();
int day = Convert.ToInt32(weekday);
Console.WriteLine(week[day -1]);