//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int num = ReadInt("Введите трехзначное число: ");
int value2 = (num % 100) / 10;

Console.WriteLine($"Вторая цифра числа {num}: {value2}");


