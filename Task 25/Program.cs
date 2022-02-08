// Найти сумму чисел от 1 до А
int a = 0, sum = 0;
string s = string.Empty;

System.Console.Write("Введите число ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

for (int i = 1; i <= a; i++)
{
    sum = sum + i;
}

System.Console.WriteLine("Сумма чисел от 1 до " + a + " равна "+ sum);
