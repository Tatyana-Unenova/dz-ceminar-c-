// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите  число ");
int A = Convert.ToInt32(Console.ReadLine());
int s = 0;
int N = A;

for (int i = 1; i < N; i = i * 10)
{
    int x = A % 10;
    A = A / 10;
    s = s + x;

}
Console.WriteLine(s);