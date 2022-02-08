// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int a = new Random().Next(10,100);
int [] arr = new int[2];
int max = 0;

System.Console.WriteLine(a);

for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = a%10;
        a = a/10;
    }

max = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] > max) max = arr[i];
}

System.Console.WriteLine("Наибольшая цифра " + max);