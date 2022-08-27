// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Clear();
System.Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(System.Console.ReadLine()!);
if (number > 7)
{
    System.Console.WriteLine($"В неделе всего 7 дней!");
    return;
}

if (number < 6)
{
    System.Console.WriteLine($"Этот день не является выходным");
}

else
{
    System.Console.WriteLine($"Этот день выходной");
}

