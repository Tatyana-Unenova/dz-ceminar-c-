// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
//  и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение элемента");
int N = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[rows,cols ];
FillArray(array);
PrintArray(array);

Searching(array, N);

void Searching(int[,] array, int N)
{
    bool find = false;
     int [] poz = new int [2]; 
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
                if (array[i,j]==N) 
                {
                          
                    poz[0]=i;
                    poz[1]=j;
                    find = true;
                    break;
                }
            
            }
        

    
    
    if (find == false) Console.WriteLine("такого элемента нет ");
    else Console.WriteLine ($"такой элемент находится в {poz[0]+1} строке, в {poz[1]+1} стодбце ");
    
}

void FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(-10,11);
}

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],5} \t");
        Console.WriteLine();
    }
}

