// Написать программу вычисления значения функции y = f(a)
// возьмем для примера простую функцию y = 2*x2 + 1

int a = 0;
string s = String.Empty;

System.Console.WriteLine("Введите аргумент функции ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

double Func(int b)
{
    double res = 0;
    res = 2*(Math.Pow(b,2)) + 1;
    return res;
}

System.Console.WriteLine("Значение функции " + Func(a));