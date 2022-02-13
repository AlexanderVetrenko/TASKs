// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

double k1 = 0, b1 =0, k2 = 0, b2 = 0, range0 = 0, range1, step = 0, x = 0;
Input(out k1,out b1,out k2,out b2, out range0, out range1, out step);

if(Solve(k1,b1,k2,b2, range0,range1,step,out x) == true)
System.Console.WriteLine("Решение найдено в точке х " + Math.Round(x,2) + " Y1 равно " + Math.Round(F(k1,b1,x),2) + " Y2 равно " + Math.Round(F(k2,b2,x),2));
else System.Console.WriteLine("Решение на указанном диапазоне не найдено");

void Input (out double k1, out double b1, out double k2, out double b2, out double range0, out double range1, out double step)
{
    string s = string.Empty;

    System.Console.Write("Введите коэффициент k1 ");
    s = Console.ReadLine();
    k1 = Convert.ToDouble(s);

    System.Console.Write("Введите значение b1 ");
    s = Console.ReadLine();
    b1 = Convert.ToDouble(s);

    System.Console.Write("Введите коэффициент k2 ");
    s = Console.ReadLine();
    k2 = Convert.ToDouble(s);
    
    System.Console.Write("Введите значение b2 ");
    s = Console.ReadLine();
    b2 = Convert.ToDouble(s);
    
    System.Console.Write("Введите начало диапазона значений х ");
    s = Console.ReadLine();
    range0 = Convert.ToDouble(s);

    System.Console.Write("Введите конец диапазона значений х ");
    s = Console.ReadLine();
    range1 = Convert.ToDouble(s);

    System.Console.Write("Введите шаг перебора значений х ");
    s = Console.ReadLine();
    step = Convert.ToDouble(s);
}

double F(double k, double b, double x)
{
    return k*x + b;
}

bool Solve(double a, double b, double c, double d, double range0, double range1, double e, out double x) 
{
    for (x = range0; x <= range1; x = x + e)
    {
        if(Math.Abs(F(a,b,x) - F(c,d,x)) <= 0.001)
        {
            return true;
        }
    }
    return false;
}

/*void Print(double s)
{
    System.Console.WriteLine("Точка пересечения двух прямых " + s);
}*/
