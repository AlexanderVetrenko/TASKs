/* Написать программу показывающую первые N чисел, 
для которых каждое следующее равно сумме двух предыдущих. 
Первые два элемента последовательности задаются пользователем */

double a, b;
int c;

Input(out a, out b, out c);
System.Console.WriteLine();
System.Console.Write($"{a} |{b} |");
for (int i = 3; i <= c; i++)
{
    System.Console.Write($"{(Fibonacci(i-2)*a + Fibonacci(i-1)*b):F1} |");
}

/* Простое решение циклом выглядит так:
создаем массивчик double [] nmbrs = new double[c]
nmbrs[0] = a; nmbrs[1] = b;
for (int i = 2; i < c; i++)
{
    nmbrs[i] = nmbrs[i - 1] + nmbrs[i - 2];
}*/

void Input(out double n, out double m, out int s)
{
    System.Console.WriteLine("Введите первое число последовательности:  ");
    n = double.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите второе число последовательности:  ");
    m = double.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите количество чисел последовательности:  ");
    s = int.Parse(Console.ReadLine());
}

double Fibonacci(int n)
 {
     if(n == 1 || n == 2) return 1;
     else return Fibonacci(n-1) + Fibonacci(n-2);
 }








