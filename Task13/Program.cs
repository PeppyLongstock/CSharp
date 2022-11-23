/*Задача 13: Напишите программу, которая выводит третью цифру заданного
 числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Console.Write("Enter a Number: ");
int Number = Convert.ToInt32(Console.ReadLine());
string SecondNumber = Convert.ToString(Number);
Console.WriteLine("The second digit of this number: "+SecondNumber[1]);
