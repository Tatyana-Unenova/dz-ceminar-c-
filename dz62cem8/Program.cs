// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
int cols = N;
int[,] array = new int[N, cols];
FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    int k = 1;

    int s = 1;
    while (k <= N / 2)
    {
        for (int j = k - 1; j < N - k; j++)

            array[k - 1, j] = s + j;

        s += (N - 1 - 2 * (k - 1));

        for (int i = k - 1; i < N - k; i++)

            array[i, N - k] = s + i;
        s += (N - 1 - 2 * (k - 1));
        for (int j = N - k; j > k - 1; j--)

            array[N - k, j] = s + (N - 1 - j);
        s += (N - 1 - 2 * (k - 1));
        for (int i = N - k; i > k - 1; i--)

            array[i, k - 1] = s + (N - 1 - i);

        s += (N - 2 - 2 * (k - 1));
        k++;
    }
    if (N % 2 != 0)
        array[N / 2, N / 2] = N * N;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j], 5} \t");
        Console.WriteLine();
    }
}
