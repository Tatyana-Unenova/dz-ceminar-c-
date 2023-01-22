// Задача 52. Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());


double [,] array = new double[rows,cols ];
FillArray(array);
PrintArray(array);
Srednee(array);

void Srednee(double[,] array)
{
      
    double [] sr=new double [array.GetLength(1)]; 
    
        for (int j=0;j<array.GetLength(1);j++)
            {
                double sum=0;
                for (int i=0;i<array.GetLength(0);i++)
                {
                     sum+= array[i,j];
                     
                }
                 sr[j]=sum/array.GetLength(0);
            } 
        for (int j=0;j<array.GetLength(1);j++)     
            Console.Write($"{sr[j],3 }\t ");           
}

void FillArray(double[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(-10,11);
}

void PrintArray(double[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],5} \t");
        Console.WriteLine();
    }
}

