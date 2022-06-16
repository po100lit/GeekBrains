using static System.Console;
Clear();

/*
В некотором алфавите имеются 4 буквы "а", "и", "с", "в".
Покажите все слова, сосотоящие из T букв, которые можно составить из этого алфавита.
*/

char[] s = { 'a', 'и', 'c', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++) // T=1
{
    for (int j = 0; j < count; j++) // T=2
    {
        WriteLine($"{n++,-5}{s[i]}{s[j]}");
    }
}

n = 1;
FindWords("аисв", new char[4]);

void FindWords(string alphabet, char[] word, int lenght = 0)
{
    if (lenght == word.Length)
    {
        WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[lenght] = alphabet[i];
        FindWords(alphabet, word, lenght + 1);
    }
}
