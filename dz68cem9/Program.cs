// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите натуральное число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AkkermanRec(m, n));

int 
AkkermanRec(int m, int n)
{
    if (m == 0)
        return n+1;
        if (n==0 ) return AkkermanRec(m-1, 1);

    return AkkermanRec(m-1, AkkermanRec(m, n-1));
}