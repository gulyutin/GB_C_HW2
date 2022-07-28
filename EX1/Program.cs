// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// 456 -> 46 782 -> 72 918 -> 98

Console.Write("Введите трехзначное число: ");
string firstString = Console.ReadLine();
int firstArg = Convert.ToInt32(firstString);
int SecondNumber = 0;
if (firstArg > 9 && firstArg < 1000)
    {
        SecondNumber = firstArg % 100 / 10;
        Console.WriteLine("Вторая цифра числа -> ");
        Console.Write(SecondNumber);
    }
        else 
        Console.WriteLine("Число не является трехзначным");
