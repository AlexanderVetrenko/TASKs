//Показать числа Фибоначчи

int a = 0;
string s = String.Empty;

System.Console.WriteLine("Введите количество чисел Фибоначчи (не менее 2)");
s = Console.ReadLine();
a = Convert.ToInt32(s);

int [] arr = new int[a];
arr[0] = 0; arr[1] = 1;

for (int i = 2; i < arr.Length; i++)
{
    arr[i] = arr[i-1] + arr[i-2];
}

for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write(arr[i] + " ");
}
