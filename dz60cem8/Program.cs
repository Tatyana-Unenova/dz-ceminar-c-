// Задача 60. ...Сформируйте трёхмерный массив из уникальных двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество рядов");
int d3 = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[rows, cols, d3];
FillArray(array);
PrintArray(array);
UnikArray(array);

void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                array[i, j, k] = new Random().Next(10, 100);
}

void UnikArray(int[,,] array)
{
    int[] countarray = new int[90];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                countarray[array[i, j, k]]++;

    for (int l = 10; l < 100; l++)
        if (countarray[l] > 1)
            Console.WriteLine($" Число {l} встречается {countarray[l]}, надо заменить");
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k], 5},({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}
