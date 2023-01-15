// По заданному номеру дня недели вывести его название

string SearchWeekDay(int weekNumber)
{
    string[] week = {
    "Такого дня недели не существует! Введите верное число",
    "понедельник",
    "вторник",
    "среда",
    "четверг",
    "пятница",
    "суббота",
    "воскресенье"};

    if(weekNumber < 1 || weekNumber > 7)
    {
        Console.WriteLine(week[0]);
        return week[0];
    }
    else
    {
        Console.Write("День ");
        Console.Write(weekNumber);
        Console.Write(" - это ");
        Console.WriteLine(week[weekNumber]);
        return week[weekNumber];
    }
}

Console.Write("Введите номер дня недели от 1 до 7: ");

int weekNumber = Convert.ToInt32(Console.ReadLine());
SearchWeekDay(weekNumber);