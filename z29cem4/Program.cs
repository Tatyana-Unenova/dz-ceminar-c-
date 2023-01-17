//  Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры 
// и далее выводит массив на экран в одну строку.

int[] array = new int[8];
Ran(array);
Print(array);

void Ran(int[] col)
{
    int i=0;
     while (i<col.Length)
    {
          Console.WriteLine($"Введите {i} число ");
                
          col[i] = Convert.ToInt32(Console.ReadLine());
          i++;
        
    }

}
void Print(int[] col2)
{
    foreach (int item in col2)
        Console.Write(item + " ");
}
