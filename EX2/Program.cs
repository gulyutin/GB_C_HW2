// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
string firstString = Console.ReadLine();
int firstArg = Convert.ToInt32(firstString);
int SecondNumber = 0;
if (firstArg > 100)
    {
        SecondNumber = firstArg % 1000 / 100;
        Console.Write("Третья цифра числа -> ");
        Console.Write(SecondNumber);
    }
        else 
        Console.WriteLine("Третьей цифры нет");
