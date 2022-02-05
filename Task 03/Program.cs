// Даны два числа. Показать большее и меньшее число

int a = 0, b = 0;
string s;

System.Console.WriteLine("Введите первое число ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

System.Console.WriteLine("Введите второе число ");
s = Console.ReadLine();
b = Convert.ToInt32(s);

if (b > a) System.Console.WriteLine("Большее число " + b + ". " + "Меньшее число " + a + ".");
if (b == a) System.Console.WriteLine("Оба числа равны.");
if (b < a) System.Console.WriteLine("Большее число " + a + ". " + "Меньшее число " + b + ".");