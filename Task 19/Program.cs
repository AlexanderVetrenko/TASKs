// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int x = 0, y = 0;
string s = String.Empty;

System.Console.WriteLine("Введите значение Х ");
s = Console.ReadLine();
x = Convert.ToInt32(s);

System.Console.WriteLine("Введите значение Y ");
s = Console.ReadLine();
y = Convert.ToInt32(s);

if(x > 0 && y > 0) System.Console.WriteLine("Точка с координатами Х = " + x + " Y = " + y + " находится в 1-ой четверти плоскости");
if(x > 0 && y < 0) System.Console.WriteLine("Точка с координатами Х = " + x + " Y = " + y + " находится в 4-ой четверти плоскости");
if(x < 0 && y < 0) System.Console.WriteLine("Точка с координатами Х = " + x + " Y = " + y + " находится в 3-ей четверти плоскости");
if(x < 0 && y > 0) System.Console.WriteLine("Точка с координатами Х = " + x + " Y = " + y + " находится во 2-ой четверти плоскости");
if(x == 0 && y != 0) System.Console.WriteLine("Точка лежит на оси Х");
if(x != 0 && y == 0) System.Console.WriteLine("Точка лежит на оси Y");
if(x == 0 && y == 0) System.Console.WriteLine("Точка находится в начале координат");