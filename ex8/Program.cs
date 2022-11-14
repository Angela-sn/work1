// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Задача №8
// // Запрос  число N
Console.WriteLine("Показать все чётные числа от 1 до N");
Console.Write("введите число: ");
int N = int.Parse(Console.ReadLine());
int x = 1;

while (x <= N)
{
    if (x % 2 == 0)
    Console.WriteLine($" {N} -> {x};");
    x = x + 1;
}
