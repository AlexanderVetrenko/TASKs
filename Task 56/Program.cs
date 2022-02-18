// Написать программу, которая обменивает элементы первой строки и последней строки

int x = 0, y = 0;

Input(out x, out y);
int[,] matrix = new int[x, y];
FillArray(matrix, x, y);
PrintArray(matrix);
System.Console.WriteLine("Массив после замены элементов первой и последней строк");
ExchangeElemnts(matrix, y);
PrintArray(matrix);



void Input(out int m, out int n)
{
    string s = string.Empty;

    System.Console.Write("Введите количество строк массива ");
    s = Console.ReadLine();
    m = Convert.ToInt32(s);

    System.Console.Write("Введите количество столбцов массива ");
    s = Console.ReadLine();
    n = Convert.ToInt32(s);
}
void FillArray(int[,] arr, int a, int b)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],3} |");
        }
        System.Console.WriteLine();
    }
}
void ExchangeElemnts(int[,] arr, int a)
{
    int[] array = new int[a];
    int m = arr.GetLength(0) - 1;
    // Копируем первую строку массива во вспомогательный массив
    for (int i = 0; i < a; i++)
    {
        array[i] = arr[0, i];
    }
    // Копируем последнюю строку массива в первую
    for (int i = 0; i < a; i++)
    {
        arr[0, i] = arr[m, i];
    }
    // Копируем в последнюю строку значения из вспомогательного массива
    for (int i = 0; i < a; i++)
    {
        arr[m, i] = array[i];
    }
}
