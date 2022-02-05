//Вывести квадрат числа
double a=-1;
string s;

System.Console.WriteLine("Введите число ");
s = Console.ReadLine();
a = Convert.ToDouble(s);
System.Console.WriteLine($"{a*a,0:F2}");
