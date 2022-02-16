// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int x = 0, y = 0;

Input(out x, out y);
double [,] matrix = new double[x,y];
FillArray(matrix, x,y);
PrintArray(matrix, x,y);
System.Console.WriteLine();
SquareElemnts(matrix,x,y);
PrintArray(matrix, x,y);



void Input (out int m, out int n)
{
    string s = string.Empty;

    System.Console.Write("Введите количество строк массива ");
    s = Console.ReadLine();
    m = Convert.ToInt32(s);

    System.Console.Write("Введите количество столбцов массива ");
    s = Console.ReadLine();
    n = Convert.ToInt32(s);
}

void FillArray(double[,] arr, int a, int b)
{
    double c = 0;
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            c = Convert.ToDouble(new Random().Next(1,40));
            arr[i,j]=Math.Round(c/4,2);
        }
    }
}

void PrintArray (double[,] arr, int a, int b)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void SquareElemnts(double[,] arr, int a, int b)
{
    for (int i = 1; i < a; i++)
    {
        for (int j = 1; j < b; j++)
        {
            if(i%2==0 && j%2==0) arr[i,j]=Math.Pow(arr[i,j],2);
        }
    }
}
