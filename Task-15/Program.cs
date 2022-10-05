// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру (день недели 1-7): ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day <= 7) 
    {
    if (day >= 6) Console.WriteLine($"{day} -> да (выходной)");
    else Console.WriteLine($"{day} -> нет (будни)");
    }
else Console.WriteLine($"{day} -> такого дня недели нет");