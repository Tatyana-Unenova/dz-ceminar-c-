// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// Console.WriteLine("введите координату x ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координату y ");
// int y = Convert.ToInt32(Console.ReadLine());
// checkkoord(x,y);
// checkkoord2(x,y);

// Console.WriteLine(checkkoord2(x, y));

// if (x>0 && y>0) Console.WriteLine( "Это четверть № 1 ");
// else if (x>0 && y<0) Console.WriteLine("Это четверть № 4 ");
// else if (x<0 && y<0) Console.WriteLine("Это четверть № 3 ");
// else if (x<0 && y>0) Console.WriteLine("Это четверть № 2 ");
// else Console.WriteLine("точка лежит на оси  ");

// void checkkoord(int x, int y)
// {
// if (x>0 && y>0) Console.WriteLine( "Это четверть № 1 ");
// else if (x>0 && y<0) Console.WriteLine("Это четверть № 4 ");
// else if (x<0 && y<0) Console.WriteLine("Это четверть № 3 ");
// else if (x<0 && y>0) Console.WriteLine("Это четверть № 2 ");
// else Console.WriteLine("точка лежит на оси  ");
// }

// string checkkoord2(int x, int y)
// {
//     string res =string.Empty;
//     if (x > 0 && y > 0) res ="Это четверть № 1 ";
//     else if (x > 0 && y < 0) res ="Это четверть № 4 ";
//     else if (x < 0 && y < 0) res ="Это четверть № 3 ";
//     else if (x < 0 && y > 0) res ="Это четверть № 2 ";
//     else res ="точка лежит на оси  ";
//     return res;
// }

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("введите целое число");
int x = Convert.ToInt32(Console.ReadLine());
for (int i=1;i<=x;i++)
{
    Console.Write($"{Math.Pow(i,2)}, ");
}


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, 
// потом задаются координаты точек.

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

// Задача 27. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.

// 452 -> 3

// 82 -> 2

// 9,012 ->4

// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

try
{
    Console.WriteLine("Введите натуральное число");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма чисел от 1 до {N} равна {Summa(N)}");
}
catch
{
    Console.WriteLine("надо было вводить именно целое число");
}

int Summa(int N)
{
    int sum = 0;
    for (int i=1;i<=N;i++)
        sum+=i;
    return sum;
}

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void Ran(int[] col)
{
    for (int index = 0; index < col.Length; index++)
        col[index] = new Random().Next(0, 2);
}

void Print(int[] col2)
{
    foreach (int item in col2)
        Console.Write(item + " ");
}

bool ZZZ(int[] col3)
{
    int a = 0;
    int b = 0;
    for (int index = 0; index < col3.Length; index++)
    {
        if (col3[index] == 1) a = a + 1;
        else b = b + 1;
    }
    if (a > b) return true;
    else return false;
}


int [] array = new int[8];
Ran(array);
Print(array);
Console.WriteLine(ZZZ(array));

// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры 
// и далее выводит массив на экран в одну строку.

int[] array = new int[8];
Ran(array);
Print(array);

void Ran(int[] col)
{
    for ( int i= 0; i < col.Length; i++)
        Console.WriteLine($"Введите {i} число ");
        // col[0]= Convert.ToInt32(Console.ReadLine());
        int col[i] = int.ToInt32(Console.ReadLine());
        // int A = Convert.ToInt32(Console.ReadLine());


}
void Print(int[] col2)
{
    foreach (int item in col2)
        Console.Write(item + " ");
}
