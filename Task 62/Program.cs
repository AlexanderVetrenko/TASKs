// В двумерном массиве целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

// Решение задачи страдает изъяном - в случае, если в массиве есть несколько одинаковых
// минимумов, данная программа удалит только первый найденный.

int x, y, s, k;

Input(out x, out y);
int[,] matrix = new int[x, y];
FillArray(matrix);
PrintArray(matrix);
FindMin(matrix, out s, out k);
System.Console.WriteLine();
PrintArray(MatrixWthoutMin(matrix, s, k));



void Input(out int m, out int n)
{
    System.Console.Write("Введите количество строк массива: ");
    m = int.Parse(Console.ReadLine());

    System.Console.Write("Введите количество столбцов массива: ");
    n = int.Parse(Console.ReadLine());
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
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
            System.Console.Write($"{arr[i, j],4} |");
        }
        System.Console.WriteLine();
    }
}

void FindMin(int[,] arr, out int m, out int n)
{
    int min = arr[0, 0], a = 0, b = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                a = i; b = j;
            }
        }
    }
    m = a; n = b;
}

int[,] MatrixWthoutMin(int[,] arr, int m, int n)
{
    int[,] matr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int k = 0, l = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i != m)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j != n)
                {
                    matr[k, l] = arr[i, j];
                    l++;
                }
            }
            k++;
            l=0;
        }
    }
    return matr;
}


