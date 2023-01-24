// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк 1 матрицы");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1 матрицы");
int cols1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество строк 2 матрицы должно равняться количеству столбцов 1 матрицы");
int rows2 = cols1;
Console.WriteLine("Введите количество столбцов 2 матрицы");
int cols2 = Convert.ToInt32(Console.ReadLine());


int[,] array1 = new int[rows1, cols1];
int[,] array2 = new int[rows2, cols2];

FillArray(array1);
FillArray(array2);
PrintArray(array1);
Console.WriteLine("это первая матрица");
PrintArray(array2);
Console.WriteLine("это вторая матрица");
Console.WriteLine("это произведение матриц");
ProdMatric(array1, array2);

void ProdMatric(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[rows1, cols2];


    for (int i = 0; i < array1.GetLength(0); i++)
    {


        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
            Console.Write($"{array3[i, j],5} \t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine("Введите  элементы матрицы");
            array[i, j] = Convert.ToInt32(Console.ReadLine());
        }
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