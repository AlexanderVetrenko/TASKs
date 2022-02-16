// Показать натуральные числа от M до N, N и M заданы

int x = 0, y = 0;

Input(out x, out y);
PrintResult(x, y, Solve(x, y));

void Input (out int n, out int m)
{
    string s = string.Empty;
    System.Console.WriteLine("Введите число N  ");
    s = Console.ReadLine();
    n = Convert.ToInt32(s);

    System.Console.WriteLine("Введите число M  ");
    s = Console.ReadLine();
    m = Convert.ToInt32(s);
}

string Solve(int a, int b)
{   
    if (a==b) return $"{b}";
    else return a + " " + Solve(a+1, b);
}

void PrintResult(int a, int b, string d)
{
    System.Console.WriteLine("Ряд натуральных чисел от " + a + " до " + b + " равен " + d);
}

