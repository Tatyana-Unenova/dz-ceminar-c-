// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

double[] array = new double[4];
Ran(array);
Print(array);
Razn(array);

void Ran(double[] col)
{
    for (int index = 0; index < col.Length; index++)
        col[index] = new Random().Next(-10, 20);
}

void Print(double[] col2)
{
    foreach (double item in col2)
        Console.Write(item + " ");
}

void Razn(double[] col)
{
    double max = col[0];
    double min = col[0];

    for (int index = 1; index < col.Length; index++)
    {
        if (col[index] > max) max = col[index];
        if (col[index] < min) min = col[index];


    }
    double razn = max - min;
    Console.WriteLine("");
    Console.WriteLine($"Разница между максимальным  и минимальным элементами массива: {razn}");
}