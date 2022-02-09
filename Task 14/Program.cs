// Выяснить, кратно ли число заданному, если нет, вывести остаток

int a = 0, b = 0;
string s;

System.Console.WriteLine("Введите число ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

System.Console.WriteLine("Введите делитель ");
s = Console.ReadLine();
b = Convert.ToInt32(s);

if(a%b == 0)
{
    System.Console.WriteLine("Число " + a + " кратно числу " + b);
}
else System.Console.WriteLine("Остаток от деления числа " +a+ " на число " +b+" равен " + a%b);