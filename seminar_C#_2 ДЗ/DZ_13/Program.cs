// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Clear();

System.Console.WriteLine("Введите свое число: ");
int input = int.Parse(System.Console.ReadLine()!);
int number = input;

if (number < 100) 
{
    System.Console.WriteLine($"В числе {input} третьей цифры нет");
    return;
}

while (number >= 1000) number /= 10;
int thirdNumber = number % 10;

System.Console.WriteLine($"Третья цифра числа {input}: {thirdNumber}");