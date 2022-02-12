// Выяснить являются ли три числа сторонами треугольника

int x = 0, y = 0, z = 0;

Input(out x, out y, out z);
Print(Solve(x,y,z));

void Input (out int x, out int y, out int z)
{
    string s = string.Empty;

    System.Console.Write("Введите число 1 ");
    s = Console.ReadLine();
    x = Convert.ToInt32(s);

    System.Console.Write("Введите число 2 ");
    s = Console.ReadLine();
    y = Convert.ToInt32(s);

    System.Console.Write("Введите число 3 ");
    s = Console.ReadLine();
    z = Convert.ToInt32(s);
}

bool Solve(int a, int b, int c)
{
    bool f = false;
    if(a < (b + c) && a > Math.Abs(b-c) && b < (a + c) && b > Math.Abs(a-c) && c < (b + a) && c > Math.Abs(b-a))
    {
        f= true;
    }
    return f;
}

void Print(bool r)
{
    if(r == true) System.Console.WriteLine("Введенные числа являются сторонами трегуольника");
    if(r == false) System.Console.WriteLine("Введенные числа НЕ являются сторонами трегуольника");
}
