// Написать программу масштабирования фигуры

struct Point
{
    // ООП - инкапсуляция
    public double x, y; // поля
    public string name = String.Empty;
    public void Print()
    {
        System.Console.WriteLine($"Вершина {name}, x = {x} y = {y}");
    }
}

class Program
{
    static void Masht(double k, ref Point a, ref Point b, ref Point c, ref Point d) // передача по значению, а нужно реализовать по ссылке (при помощи ref)
    // массивы, в отличие от переменных, сразу передаются по ссылке
    {
        a.x = a.x * k;
        a.y = a.y * k;
        b.x = b.x * k;
        b.y = b.y * k;
        c.x = c.x * k;
        c.y = c.y * k;
        d.x = d.x * k;
        d.y = d.y * k;
    }

    /* static void Mashtab(int k, Point[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i].x *= k;
            arr[i].y *= k;
        }
    }

    static void Calc(int a, int b, out int multi, out int sum)
    {
        multi = a * b;
        sum = a + b;
    } */
    static void Input (out double z)
    {
        System.Console.WriteLine("Введите коэффициент масштабирования: ");
        z=double.Parse(Console.ReadLine());
    }
    static void Main()
    {
        /* Point[] points = new Point[2];
        points[0].x = 0;
        points[0].y = 2;
        points[1].x = 3;
        points[1].y = 4;
        Mashtab(2, points);// - это вариант с использованием массива */
        
        //int x = 1, y = 2, m = 0, s = 0;
        //Calc(x, y, out m, out s);
        double s;
        Point a, b, c, d;
        a.x = 0;
        a.y = 2;
        a.name = "a";
        b.x = 1;
        b.y = 3;
        b.name = "b";
        c.x = 2;
        c.y = 4;
        c.name = "c";
        d.x = 5;
        d.y = 3;
        d.name = "d";
        System.Console.WriteLine("Координаты вершин фигуры до масштабирования:");
        a.Print();
        b.Print();
        c.Print();
        d.Print();
        Input(out s);
        Masht(s, ref a, ref b, ref c, ref d);
        System.Console.WriteLine();
        System.Console.WriteLine($"Координаты вершины фигуры после масштабирования с коэффициентом к = {s}:");
        System.Console.WriteLine();
        a.Print();
        b.Print();
        c.Print();
        d.Print();
    }
}


/*int[] a = { 1, 2 };
int[] b = { 2, 3 };
int[] c = { 4, 5 };*/