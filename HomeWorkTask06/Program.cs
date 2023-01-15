// Задача 6. Показать чётные числа от 1 до N

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;

Console.WriteLine("Чётные числа от 1 до N:");

while (i <= n)
{
    Console.Write(i);

    if (i < n - 1)
    {
        Console.Write(", ");
    }

    i += 2;
}