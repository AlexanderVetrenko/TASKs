// По двум заданным числам проверять является ли одно квадратом другого
double a = 0, b = 0;
string s;

System.Console.WriteLine("Введите первое число ");
s = Console.ReadLine();
a = Convert.ToDouble(s);

System.Console.WriteLine("Введите второе число ");
s = Console.ReadLine();
b = Convert.ToDouble(s);

if (a == Math.Pow(b,2)) System.Console.WriteLine("Первое число является квадратом второго!");
if (b == Math.Pow(a,2)) System.Console.WriteLine("Второе число является квадратом первого!");
if (a != Math.Pow(b,2) && b != Math.Pow(a,2)) System.Console.WriteLine("Ни одно из чисел не является квадратом другого");