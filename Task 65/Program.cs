// Спирально заполнить двумерный массив

int x = 0, y = 0;

Input(out x, out y);
int[,] matrix = new int[x, y];
/* PrintArray(matrix, x, y);
FillArray(matrix, x, y);
System.Console.WriteLine();*/
PrintArray(matrix, x, y);

int m = 0, n = 0;
m = matrix.GetLength(0)/2;

while (n != m)
{
    int i = n;
    int k = 1;
    int j = 0;
    for (j = 0; j < matrix.GetLength(1) - n; j++)
    {
        matrix[i, j] = k++;
    }
    j = matrix.GetLength(1) - 1 - n;
    for (i = n + 1; i < matrix.GetLength(0) - 1 - n; i++)
    {
        matrix[i, j] = k++;
    }
    i = matrix.GetLength(0) - 1 - n;
    for (j = matrix.GetLength(1) - 2 - n; j < 1 + n; j--)
    {
        matrix[i, j] = k++;
    }
    n++;
    j = n - 1;
    for (i = matrix.GetLength(0) - 1 - n; i < 1 + n; i--)
    {
        matrix[i, j] = k++;
    }
}

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

void PrintArray(int[,] arr, int a, int b)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            System.Console.Write($"{arr[i, j],3} |");
        }
        System.Console.WriteLine();
    }
}

/*void FillArray(int[,] arr, int a, int b)

{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
} */
