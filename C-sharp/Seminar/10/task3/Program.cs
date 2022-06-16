using static System.Console;
Clear();

/*
Задача 71:** В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.

n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, ав, ва, ви, ив, св, вс
*/

string charWords = "abce";
int countCharInWords = 2;
PrintAllWords(charWords, countCharInWords, "");

void PrintAllWords(string alphabet, int lenght, string prefix)
{
    if (lenght == 0) WriteLine(prefix);
    else
        foreach (char item in alphabet)
        {
            PrintAllWords(alphabet, lenght - 1, prefix + item);
        }
}
