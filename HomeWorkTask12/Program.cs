// Задача 12. Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число: ");
string num = Console.ReadLine();

int strLength = num.Length;

if (strLength >= 3)
{
    Console.Write("Третья цифра числа: ");
    Console.WriteLine(num[2]);
}
else
{
    Console.WriteLine("Третьей цифры в данном числе нет!");
}
