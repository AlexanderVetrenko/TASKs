// Определить количество цифр в числе

string s = String.Empty;

System.Console.WriteLine("Введите число ");
s = Console.ReadLine();

int Quant(string txt)
{
    int count  = 0;
    for (int i = 0; i < txt.Length; i++)
    {
        count++;
    }
    return count;
}

System.Console.WriteLine($"Количество цифр в числе равно " + Quant(s));