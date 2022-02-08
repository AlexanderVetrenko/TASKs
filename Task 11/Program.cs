// Показать вторую цифру трёхзначного числа

int a = 0;
string s = string.Empty;

System.Console.Write("Введите трехзначное число ");
s = Console.ReadLine();
a = Convert.ToInt32(s.Length);

if(a == 3) System.Console.WriteLine("Вторая цифра трехзначного числа " + s[s.Length-2]);
else System.Console.WriteLine("Число не является трехзначным");