using static System.Console;
Clear();

/*
Собрать строку с числами от А до В, известно что А <= В
*/

WriteLine(NumbersFor(1, 10));
WriteLine(NumbersRec(1, 10));

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}
