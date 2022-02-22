// Найти сумму цифр числа

int x;

Input(out x);
PrintResult(x, NumbrsSum(x));

void Input (out int n)
{
    System.Console.WriteLine("Введите целое число  ");
    n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    
}

int NumbrsSum(int a)
{   
    if (a/10 == 0) return a;
    else return a%10 + NumbrsSum(a/10);
}

void PrintResult(int a, int b)
{
    System.Console.WriteLine($"Сумма цифр числа {a} равна {b}.");
}



