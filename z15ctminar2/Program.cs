﻿// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите число от 1 до 7");
int x=Convert.ToInt32 ( Console.ReadLine());
if ((x==6) || (x==7)) Console.WriteLine("это выходной");
else Console.WriteLine("это не выходной");
     

    