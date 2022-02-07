// Показать четные числа от 1 до N

int a = 0;
string s = String.Empty;

System.Console.WriteLine("Введите число ");
s = Console.ReadLine();
a = Convert.ToInt32(s);
//int [] arr = new int [a+1];

for (int i = 1; i <= a; i++)
{
    if(i%2 == 0) System.Console.Write(i + " ");
}