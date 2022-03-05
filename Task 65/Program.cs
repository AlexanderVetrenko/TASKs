// Спирально заполнить двумерный массив

int x = 0, y = 0;
int m = 0, n = 0;
int k = 1;

Input(out x, out y);
int[,] matrix = new int[x, y];
m = (Math.Min(matrix.GetLength(0), matrix.GetLength(1))) / 2;
SpiralArray(matrix, m, n, k);
System.Console.WriteLine();
PrintArray(matrix);


void SpiralArray(int[,] arr, int t, int l, int s) // t соответствует m, l соответствует n, s соответствует k
//                  matrix       m      n      k
{
    int i, j;
    while (l <= t)
    {
        i = l;
        for (j = l; j < (arr.GetLength(1) - l); j++)
        {
            arr[i, j] = s++;
        }
        j = (arr.GetLength(1) - 1 - l);
        for (i = (l + 1); i < (arr.GetLength(0) - l); i++)
        {
            arr[i, j] = s++;
        }

        i = (arr.GetLength(0) - 1 - l);
        for (j = (arr.GetLength(1) - 2 - l); j >= l; j--)
        {
            arr[i, j] = s++;
        }
        l++;
        j = (l - 1);
        for (i = (arr.GetLength(0) - 1 - l); i >= l; i--)
        {
            arr[i, j] = s++;
        }
    }
}

void Input(out int m, out int n)
{
    System.Console.Write("Введите количество строк массива ");
    m = int.Parse(Console.ReadLine());

    System.Console.Write("Введите количество столбцов массива ");
    n = int.Parse(Console.ReadLine());

    while (m!=n)
    {
        System.Console.WriteLine("Количество строк должно быть равно количеству столбцов!");
        Input(out m, out n);
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
