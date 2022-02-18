// Найти сумму цифр числа

int x = 0;

Input(out x);
PrintResult(x, Solve(x, y));

void Input (out int n)
{
    System.Console.WriteLine("Введите число  ");
    n = Convert.ToInt32(Console.ReadLine());
    
}

int Solve(int a)
{   
    if (a==b) return b;
    else return a + Solve(a+1, b);
}

void PrintResult(int a, int b, int d)
{
    System.Console.WriteLine("Сумма элементов от " + a + " до " + b + " равна " + d);
}



