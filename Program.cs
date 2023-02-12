// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
System.Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 2)
{
    System.Console.WriteLine("Wrong number");
}
for (int i = 2; i <= n; i+=2)
{
    System.Console.Write($"{i} ");
}
