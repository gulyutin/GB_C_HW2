// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

Console.Write("Введите первое число ");
string firstString = Console.ReadLine();
int firstArg = Convert.ToInt32(firstString);
Console.Write("Введите второе число ");
string secondString = Console.ReadLine();
int secondArg = Convert.ToInt32(secondString);
int Div = firstArg % secondArg; 

if (Div == 0)
    {
        Console.WriteLine("Кратно ");
    }
        else 
        {
        Console.Write("Не кратно, остаток ");
        Console.Write(Div);
        }
