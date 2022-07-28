// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
// 14 -> нет 46 -> нет 161 -> да

Console.Write("Введите число ");
string firstString = Console.ReadLine();
int firstArg = Convert.ToInt32(firstString);

if (firstArg % 7 == 0 && firstArg % 23 == 0)
    {
        Console.WriteLine("Да");
    }
        else 
        {
            Console.Write("Нет");
        }

