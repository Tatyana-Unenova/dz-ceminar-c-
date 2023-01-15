// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите  число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" Число {A} в степени {B} равно {Stepen(A, B)}");


int Stepen(int A, int B)
{
    int st = 1;
    for (int i = 1; i <= B; i++)
        st = st * A;
    return st;
}