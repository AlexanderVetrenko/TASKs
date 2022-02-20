// Написать программу, которая в двумерном массиве 
// заменяет строки на столбцы или сообщить, что это 
// невозможно (в случае, если матрица не квадратная).

int x, y;

Input(out x, out y);
double[,] matrix = new double[x, y];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
System.Console.WriteLine("Массив после замены строк и столбцов:");
System.Console.WriteLine();
PrintArray(EXRowsColumns(matrix));


void Input(out int m, out int n)
{
    System.Console.Write("Введите количество строк массива: ");
    m = Convert.ToInt32(Console.ReadLine());

    System.Console.Write("Введите количество столбцов массива (оно должно быть равно количеству строк): ");
    n = Convert.ToInt32(Console.ReadLine());
    while (m != n)
    {
        System.Console.WriteLine("Количество строк должно быть равно количеству столбцов,"
                                           + " иначе поменять их местами невозможно!");
        Input(out m, out n);
    }

}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],4:F1} |");
        }
        System.Console.WriteLine();
    }
}

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = (new Random().NextDouble()) * 30;
        }
    }
}

double[,] EXRowsColumns(double[,] arr)
{
    double[,] collect = new double[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            collect[i, j] = arr[j, i];
        }
    }
    return collect;
}
