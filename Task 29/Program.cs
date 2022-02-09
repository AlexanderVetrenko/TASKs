// Написать программу вычисления произведения чисел от 1 до N

int a = 0, res = 1;
string s = string.Empty;

System.Console.Write("Введите число ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

for (int i = 1; i <= a; i++)
{
    res = res * i;
}

System.Console.WriteLine("Произведение чисел от 1 до " + a + " равно "+ res);
