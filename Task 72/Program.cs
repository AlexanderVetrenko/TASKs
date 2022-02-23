// Написать программу возведения числа А в целую степень B

double x;
int y;

Input(out x, out y);
PrintResult(x, y, Grade(x, y));

void Input(out double n, out int m)
{
    System.Console.WriteLine("Введите число:  ");
    n = double.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите целую степень числа:  ");
    m = int.Parse(Console.ReadLine());
}

double Grade(double a, int b)
{
    if (b == 1) return a;
    else return a * Grade(a, b - 1);
}

void PrintResult(double a, int b, double c)
{
    System.Console.WriteLine($"Результат возведения числа {a} в степень {b} равен {c:F2}.");
}



