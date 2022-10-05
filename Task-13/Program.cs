// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int remainder = number;

if (number>99) 
    {
    while (remainder > 999)
        remainder = remainder/10 ; // 78521 / 10 = 7852;
    int thirdDigit = remainder % 10; // 785 % 10 = 5;
    Console.WriteLine($"{number} -> {thirdDigit}");
    }
else Console.WriteLine($"{number} -> третьей цифры нет");