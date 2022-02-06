// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool x = true, y = true;
int [] f = new int[4];
int n = 0, count =0;

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        if (i==0) x = false; else x = true;
        if (j==0) y = false; else y = true;
           
        if (!(x&y) == (!x)|(!y))
        {
            f[n] = 1;
        } 
        else
        {
            f[n] = 0;
        }
        n++;
    }
 }

for (int k = 0; k < n; k++)
{
    System.Console.WriteLine(f[k]);
    if(f[k] == 1) count++;
}
if(count == 4) System.Console.WriteLine("Утверждение истинно");
else System.Console.WriteLine("Утверждение ложно");