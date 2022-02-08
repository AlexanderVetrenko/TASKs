// Дано число. Проверить кратно ли оно 7 и 23

int a = 0;
string s = string.Empty;

System.Console.Write("Введите число ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

if(a%7 == 0 && a%23 == 0) System.Console.WriteLine("Введенное число кратно и 7 и 23");
else
{
    if(a%7 == 0) System.Console.WriteLine("Введенное число кратно семи");
    if(a%23 == 0) System.Console.WriteLine("Введенное число кратно двадцати трем");
}
if(a%7 !=0 && a%23 !=0) System.Console.WriteLine("Введенно число не кратно ни 7 ни 23");
