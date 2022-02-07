// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int a = 0;
string s = String.Empty;

System.Console.WriteLine("Введите число, обозначающее день недели ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

if(a == 6 | a ==7) System.Console.WriteLine("Номер дня недели " + a + " соответствует выходному дню");
else System.Console.WriteLine("Номер дня недели " + a + " не соответствует выходному дню");
