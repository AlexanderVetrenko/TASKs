// Показать числа от -N до N

int a = 0, b = 0, res = 0;
string s = String.Empty;

System.Console.WriteLine("Введите начальное отрицательное число последовательности");
s = Console.ReadLine();
a = Convert.ToInt32(s);

System.Console.WriteLine("Введите конечное положительное число последовательности ");
s = Console.ReadLine();
b = Convert.ToInt32(s);

res = b - a;
int [] arr = new int [res+1];
arr[0]= a;
arr[res] = b;

for (int i = 1; i < arr.Length-1; i++)
{
    arr[i] = arr[i-1] + 1;
}

for (int j = 0; j < arr.Length; j++)
{
    System.Console.Write(arr[j] + " ");
}