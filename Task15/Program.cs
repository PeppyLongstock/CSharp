/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber)
{
  if (dayNumber == 6 || dayNumber == 7)
  {
  Console.WriteLine("this day is a day off");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("7 days in a week!");
  }
  else Console.WriteLine("this day is working day");
}

CheckingTheDayOfTheWeek(dayNumber);