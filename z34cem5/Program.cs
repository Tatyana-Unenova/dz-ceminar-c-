// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int [] array = new int[4];
Ran(array);
Print(array);
Skolko(array);

// Console.WriteLine(ZZrray));
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

void Skolko(int[] col3)
{
    int a = 0;
    
    for (int index = 0; index < col3.Length; index++)
    {
        if (col3[index]%2 == 0) a = a + 1;
        
    }
    Console.WriteLine("");
    Console.WriteLine($"Колво чётных чисел в массиве: {a}");
}