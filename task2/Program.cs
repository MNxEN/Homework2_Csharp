// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = ReadInt("Введите число: ");
int rest = number;
if (rest > 99)
{
    while (rest > 999) rest /= 10;
    rest = rest % 10 % 10;
    Console.WriteLine($"Третья цифра числа <{number}>: {rest}");
}
else Console.WriteLine($"В числе {number} нет третьей цифры");