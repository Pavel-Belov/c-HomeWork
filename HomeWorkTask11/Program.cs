// Задача 11. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Задайте число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте кратное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int mod = num1 % num2;

if (mod == 0)
{
    Console.WriteLine("Число " + num2 + " кратно заданному числу " + num1);
}
else
{
    Console.WriteLine("Число " + num2 + " не кратно заданному числу " + num1);
    Console.WriteLine("Остаток: " + mod);
}