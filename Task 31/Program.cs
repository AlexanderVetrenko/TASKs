// Задать массив из 8 элементов и вывести их на экран
int [] a = new int [8];

for(int i = 0;i < a.Length; i++)
    a[i]=new Random().Next(0,100);

for(int i = 0;i<a.Length;i++)   
    System.Console.Write($"{a[i]} ");