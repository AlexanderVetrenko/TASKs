/* В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
Покажите все слова (слова не обязательно осмысленные), состоящие из n букв, 
которые можно построить из букв этого алфавита*/

class Program
{
    static void Input(out int x)
    {
        System.Console.WriteLine("Введите количество букв в каждом слове: ");
        x = int.Parse(Console.ReadLine());
    }
    static public int c = 1;
    static void FindWords(string alphabet, char[] word, int length = 0)
    {
        if (length == word.Length)
        {
            System.Console.WriteLine($"{c++} {new String(word)}"); return;
        }

        for (int i = 0; i < alphabet.Length; i++)
        {
            word[length] = alphabet[i];
            FindWords(alphabet, word, length + 1);
        }
    }
    static void Main()
    {
        int n;
        Input(out n);
        FindWords("аисв", new char[n]);
    }
}

