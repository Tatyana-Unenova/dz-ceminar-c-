﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Sort(array);
Console.WriteLine();
PrintArray(array);

void Sort(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int S = 0; S < array.GetLength(1)-1; S++)
        {

            int j=0;
            while  (j < array.GetLength(1)-1-S)
            {
                if (array[i, j] < array[i, j + 1])

                    (array[i, j], array[i, j + 1]) = (array[i, j + 1], array[i, j]);
                    j++;
            }
        }
    }

}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-10, 11);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],5} \t");
        Console.WriteLine();
    }
}