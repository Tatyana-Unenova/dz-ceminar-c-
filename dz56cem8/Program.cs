// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
int cols = rows;


int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Summa(array);


void Summa(int[,] array)
{
    int[] summa = new int[rows];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summa[i] += array[i, j];
        }

    }
    int minsum = summa[0];
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (summa[i] < minsum) index = i;
    }

    Console.WriteLine($"{index + 1}-строка с наименьшей суммой элементов ");

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