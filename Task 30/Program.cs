// Показать кубы чисел, заканчивающихся на четную цифру

int a = 0;
double n = 0, grade = 0;
string s;

System.Console.WriteLine("Введите число ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

while (a!=0) // будем выполнять программу до тех пор, пока не пользователь не введет 0
{
    grade = Math.Pow(a, 3);
    s = Convert.ToString(grade);
    n = Convert.ToDouble(s.Length-1);                       
    if (n%2 == 0)
    {
        System.Console.WriteLine($"Куб числа "+ a +" равен " + grade);
    }
    System.Console.WriteLine("Введите число ");
    s = Console.ReadLine();
    a = Convert.ToInt32(s);
}
