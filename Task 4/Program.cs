// По заданному номеру дня недели вывести его название
void WeekDay(int n)

{
    if (n == 1) System.Console.WriteLine("Это понедельник.");
    if (n == 2) System.Console.WriteLine("Это вторник.");
    if (n == 3) System.Console.WriteLine("Это среда.");
    if (n == 4) System.Console.WriteLine("Это четверг.");
    if (n == 5) System.Console.WriteLine("Это пятница.");
    if (n == 6) System.Console.WriteLine("Это суббота.");
    if (n == 7) System.Console.WriteLine("Это воскресенье.");
}

int a = 0;
string s;
bool f = true;

System.Console.Write("Введите номер дня недели: ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

while(f == true)
{
    if (a > 0 && a < 8)
    {
        WeekDay(a);
        f = false;
    }
    else
    {
        System.Console.WriteLine("Введенное Вами число не может быть сопоставлено с днем недели.");
        System.Console.Write("Введите номер дня недели: ");
        s = Console.ReadLine();
        a = Convert.ToInt32(s);
    }
}