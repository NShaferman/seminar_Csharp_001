// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Clear();

System.Console.WriteLine("Введите свое число: ");
int input = int.Parse(System.Console.ReadLine()!);
int number = input;

while (number >= 100) number /= 10;
int secondNumber = number % 10;

System.Console.WriteLine($"Вторая цифра числа {input}: {secondNumber}");
