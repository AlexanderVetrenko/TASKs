// Написать программу замену элементов массива на противоположные

/*вопрос - и что такое "на противоположные"? С противоположным знаком, что ли?
Ок, буду менять знак */

int [] Arr = new int [12];

for(int i=0; i< Arr.Length; i++)
{
    Arr[i] = new Random().Next(-9, 10);
    System.Console.Write($"{Arr[i]}" + " ");
    Arr[i] = Arr[i]*(-1);
}
System.Console.WriteLine(); // вставляем пустую строчку
for (int i = 0; i < Arr.Length; i++)
{
    System.Console.Write($"{Arr[i]}" + " ");
}