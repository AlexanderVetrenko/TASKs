// Найти третью цифру числа или сообщить, что её нет

int a = 0;
string s = string.Empty;

System.Console.Write("Введите число ");
s = Console.ReadLine();
a = s.Length;

if(a >= 3) 
{
    System.Console.WriteLine("Третья цифра числа " + s[2]);
}
else System.Console.WriteLine("В числе отсутствет третья цифра");
