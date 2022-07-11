﻿/*

Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

Console.WriteLine($"\n Exesize2. Сумма эллемнтов, стоящих на нечетных позициях:\n");
Console.Write($"Введите количество элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine());

int RandomNumbers(int numberElements, int min, int max)
{
    int[] randomNumbers = new int [numberElements];
    int sumElements = 0;
    Console.Write("Наш массив который получился: ");

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(min, max);

        Console.Write(randomNumbers[i] + " ");
        if (i % 2 != 1)
        {
            sumElements = sumElements + randomNumbers[i];
        }
    }
 
    return sumElements;   
}

int randomNumbers = RandomNumbers(numberElements, 1, 10);

Console.WriteLine($"\n Сумма элементов, стоящих на нечетных позициях: {randomNumbers}");