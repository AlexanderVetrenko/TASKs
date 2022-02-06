// Найти максимальное из трех чисел

int a = 0, b = 0, c = 0;
string s = String.Empty;

System.Console.WriteLine("Введите первое число ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

System.Console.WriteLine("Введите второе число ");
s = Console.ReadLine();
b = Convert.ToInt32(s);

System.Console.WriteLine("Введите третье число ");
s = Console.ReadLine();
c = Convert.ToInt32(s);

int Max(int fir, int sec, int thi)
{
    int res = fir;
    if (res == sec && res == thi)
    {
        return -1;
    }
    else
    {
        if(sec > res) res = sec;
        if(thi > res) res = thi;
        return res;
    }
    
}
if(Max(a,b,c) == -1) System.Console.WriteLine("Все числа равны");
else System.Console.WriteLine("Максимальное число равно " + Max(a,b,c));