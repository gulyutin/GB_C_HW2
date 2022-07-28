// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Номер дня недели: ");
string firstString = Console.ReadLine();
int firstArg = Convert.ToInt32(firstString);

if (firstArg <8)
    {
        if (firstArg <6)
            {
                Console.WriteLine("Нет");
            }
                else
                {
                    Console.WriteLine("Да");
                }
    }
        else 
        {
            Console.Write("В неделе всего 7 дней");
        }

