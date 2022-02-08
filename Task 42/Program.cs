// Определить сколько чисел больше 0 введено с клавиатуры

int n = 0, a = 0, sum = 0;
string s;

System.Console.WriteLine("Введите любое целое (положительное или отрицательное) число. Как надоест вводить числа, нажмите 0");
s = Console.ReadLine();
a = Convert.ToInt32(s);

while (a!=0)
{
    if(a > 0) sum++;

    System.Console.WriteLine("Еще число");
    s = Console.ReadLine();
    a = Convert.ToInt32(s);
}

if(sum>0) System.Console.WriteLine("Количество чисел больше ноля составляет " + sum);
else System.Console.WriteLine("Положительных чисел не введено");