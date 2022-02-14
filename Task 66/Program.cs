﻿// Показать натуральные числа от 1 до N, N задано

int x = 0;

Input(out x);
PrintResult(x, Solve(x));

void Input (out int n)
{
    string s = string.Empty;
    System.Console.WriteLine("Введите число N  ");
    s = Console.ReadLine();
    n = Convert.ToInt32(s);
}

string Solve(int a)
{
    string res = string.Empty;
    
    while (a != 0)
    {
        res = a + " " + res;
        a = a - 1;
    }
    return res;
}

void PrintResult(int a, string d)
{
    System.Console.WriteLine("Ряд натуральных чисел от 1 до " + a + " равен " + d);
}


