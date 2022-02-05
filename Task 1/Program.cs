//Вывести квадрат числа
double result=-1;
string s;

System.Console.WriteLine("Введите число ");
s = Console.ReadLine();
result = Convert.ToDouble(s);
System.Console.WriteLine($"{result*result,0:F2}");
