// Удалить вторую цифру трёхзначного числа

int a = 0;
string s = string.Empty;

System.Console.Write("Введите трехзначное число ");
s = Console.ReadLine();
a = Convert.ToInt32(s.Length);

if(a == 3) 
{
    System.Console.WriteLine("Удаляем цифру " + s[s.Length-2] + ", получаем " + s[s.Length-3] + s[s.Length-1]);
}
else System.Console.WriteLine("Число не является трехзначным");
