/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] GetRandomArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return array;
}
void print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] GetArrayConversion(int[,] array)
{

    int sizeNewArray = array.GetLength(0) * array.GetLength(1);
    int[] newArray = new int[sizeNewArray];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[index] = array[i, j];
            index++;
        }
    }
    return newArray;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

void OutputUserElement(int[] array)
{
    Console.Write("Enter the element position: ");
    int userElement = int.Parse(Console.ReadLine());
    for (int i = 0; i < array.Length; i++)
    {
        if (userElement == i)
        {
            Console.WriteLine($" The element with the index is {userElement} = {array[i]}");
        }
    }

    if (userElement > array.Length)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("No such number in the array");
        Console.ResetColor();
        Console.WriteLine();
    }
    if (userElement < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("No such number in the array");
        Console.ResetColor();
        Console.WriteLine();
    }
}
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("2Darray:");
int[,] array1 = GetRandomArray(3, 4, 10);
print2dArray(array1);
Console.ResetColor();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Converted 1d Array:");
int[] array2 = GetArrayConversion(array1);
PrintArray(array2);
Console.ResetColor();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
OutputUserElement(array2);
Console.ResetColor();