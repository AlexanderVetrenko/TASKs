// Показать натуральные числа от N до 1, N задано

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
    if (a==1) return "1";
    else return a + " " + Solve(a-1);
}

void PrintResult(int a, string d)
{
    System.Console.WriteLine("Ряд натуральных чисел от " + a + " до 1 равен " + d);
}
