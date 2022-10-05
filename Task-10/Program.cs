// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = (number / 10);

if (number >= 100 && number <= 999)
    {
    secondDigit = number/10 ; // (781/10) = 78
    secondDigit = secondDigit%10 ; // 78%10 = 8
    Console.WriteLine($"{number} -> {secondDigit}");
    }
else
    Console.WriteLine("вы ввели неверное число!");