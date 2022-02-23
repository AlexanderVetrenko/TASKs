// Написать программу масштабирования фигуры

struct Point
{
    // ООП - инкапсуляция
    public int x, y; // поля
    public void Print()
    {
        System.Console.WriteLine($"x = {x} y = {y}");
    }
}

class Program
{
    static void Masht(int k, ref Point a, ref Point b, ref Point c) // передача по значению, а нужно реализовать по ссылке (при помощи ref)
    // массивы, в отличие от переменных, сразу передаются по ссылке
    {
        a.x = a.x * k;
        a.y = a.y * k;
        b.x = b.x * k;
        b.y = b.y * k;
        c.x = c.x * k;
        c.y = c.y * k;
    }

    static void Mashtab(int k, Point[] arr)
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

        Point a, b, c;
        a.x = 0;
        a.y = 2;
        b.x = 1;
        b.y = 3;
        c.x = 2; c.y = 4;
        a.Print();
        b.Print();
        c.Print();
        Masht(2, ref a, ref b, ref c);
        a.Print();
        b.Print();
        c.Print();
    }
}


/*int[] a = { 1, 2 };
int[] b = { 2, 3 };
int[] c = { 4, 5 };*/