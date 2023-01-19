// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int [] array = new int[4];
Ran(array);
Print(array);
Sum(array);

void Ran(int[] col)
{
    for (int index = 0; index < col.Length; index++)
        col[index] = new Random().Next(100, 1000);
}

void Print(int[] col2)
{
    foreach (int item in col2)
        Console.Write(item + " ");
}

void Sum(int[] col)
{
    int sum = 0;
    
    for (int index = 0; index < col.Length; index++)
    {
        if ((index+1)%2 == 0) sum+=col[index];
        
    }
    Console.WriteLine("");
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");
}