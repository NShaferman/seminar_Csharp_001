// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");
int number_N = int.Parse(Console.ReadLine()!);

for (int num = 1; num <= number_N; num++)
if (num % 2 == 0)            
Console.WriteLine(num);