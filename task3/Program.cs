// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

//int []week = {mon}
int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = ReadInt("Введите число от 1 до 7: ");
if (number > 0 && number < 8) 
{
    if (number > 5) Console.WriteLine("Это выходной день");
    else Console.WriteLine("Это будний день");
}
else Console.WriteLine($"{number} не является днем недели!");
