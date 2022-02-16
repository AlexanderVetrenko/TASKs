// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int x = 0, y = 0;
double a = 0;
List<int> Numbrs = new List<int>();
//string r = string.Empty;

Input(out x, out y);
double [,] matrix = new double[x,y];
FillArray(matrix, x,y);
PrintArray(matrix, x,y);

System.Console.WriteLine("Введите число, позиции которого необходимо найти ");
a = Convert.ToDouble(Console.ReadLine());

FindElement(matrix, a, out Numbrs);
PrintResults(Numbrs);




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

void FindElement(double[,] arr, double b, out List<int> Indexes)
{
    //Indexes.Add(1);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           // if (arr[i,j] == b)
           // {
               Indexes.Add(i);
               Indexes.Add(j);
           // }
        }
    }
}

void PrintResults(List<int> Indexes)
{
    if(Indexes.Count == 1) System.Console.WriteLine("Такого элемента в массиве не обнаружено");
    else
    {
        for (int i = 1; i < Indexes.Count; i++)
        {
            System.Console.WriteLine($"Позиции указанного числа в массиве {Indexes[i]}");
        }
    }
}
