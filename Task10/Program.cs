/* Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

int number = new Random().Next(100, 999);

System.Console.WriteLine($"Second digit of {number} is {number / 10 % 10} ");

System.Console.WriteLine();
