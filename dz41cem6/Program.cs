// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// // сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Укажите М длину массива");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
Ran(array);
Print(array);
Skolko(array);




void Ran(int[] col)
{
    for (int index = 0; index < M ; index++)
    {  
        Console.WriteLine($"введите {index + 1} число");
        col[index] = Convert.ToInt32(Console.ReadLine()); ;
    }
}



void Print(int[] col2)
{
    foreach (int item in col2)
        Console.Write(item + " ");
}

void Skolko(int[] col)
{
    int a = 0;

    for (int index = 0; index < col.Length; index++)
    {
        if (col[index]> 0) a = a + 1;
    }
    Console.WriteLine("");
    Console.WriteLine($"Количество положительных чисел: {a} ");
}