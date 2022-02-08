// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int [] a = new int [123];
int count = 0;

for(int i = 0;i < a.Length; i++)
    a[i]=new Random().Next(0,1000);

for (int i = 0;i < a.Length; i++)
{
    if (a[i]> 9 && a[i] < 100) count++;
}

System.Console.WriteLine("Количество элементов из отрезка [10,99] составляет " + count);