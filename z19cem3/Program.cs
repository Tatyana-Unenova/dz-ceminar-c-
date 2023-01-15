// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("введите целое число");
int x = Convert.ToInt32(Console.ReadLine());
int N = razmer(x);
// Console.WriteLine($"число {N} разряд числа {x}");
int P = -1;
int M = N / 2;
for (int i = 0; i <= M; i++)
{
    int y = (int)(Math.Pow(10, N - 1));

    if ((int)(x / y) != (int)(x % 10))
    {
        P = 0;
        break;
    }

    else
    {
        x = (((int)(x % y) - x % 10) / 10);
        N = N - 2;
        P = 1;
    }

    
}
if (P == 0) Console.WriteLine("число  не является палиндромом");
else if (P == 1) Console.WriteLine("число является палиндромом");
else Console.WriteLine("что-то пошло не так");


int razmer(int x)
{
    int i = 0;
    while (x > 0)
    {
        i++;
        x = x / 10;
    }
    int res = i;
    return res;

}
