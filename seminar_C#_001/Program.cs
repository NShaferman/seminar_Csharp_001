// Задача 2: Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5, b = 25 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> нет
// a = -3, b = 9 -> да

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    Console.WriteLine("Первое число больше второго");
}
else
{
    Console.WriteLine("Первое число меньше второго");
}