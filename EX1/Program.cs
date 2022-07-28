// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
string firstString = Console.ReadLine();
int firstArg = Convert.ToInt32(firstString);
int SecondNumber = 0;
if (firstArg > 9 && firstArg < 1000)
    {
        SecondNumber = firstArg % 100 / 10;
        Console.Write("Вторая цифра числа -> ");
        Console.Write(SecondNumber);
    }
        else 
        Console.WriteLine("Число не является трехзначным");
