/* Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
Найти сумму положительных/отрицательных элементов массива */

int [] Arr = new int [12];
int a = 0, b = 0; // a - счетчик положительных чисел, b - счетчик отрицательных

for(int i=0; i< Arr.Length; i++)
{
    Arr[i] = new Random().Next(-9, 10);
    System.Console.Write($"{Arr[i]}" + " ");
    if (Arr[i] > 0 ) a = a + Arr[i];
    if (Arr[i] < 0 ) b = b + Arr[i];
}
System.Console.WriteLine();
System.Console.WriteLine("Сумма положительных элементов массива " + a);
System.Console.WriteLine("Сумма отрицательных элементов массива " + b);