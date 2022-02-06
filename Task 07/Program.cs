// Выяснить является ли число чётным

int a = 0;
string s = String.Empty;

System.Console.WriteLine("Введите число ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

if(a%2 == 0) System.Console.WriteLine("Введенное число является четным");
else System.Console.WriteLine("Введенное число является нечетным");
