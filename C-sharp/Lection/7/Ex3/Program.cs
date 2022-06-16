using static System.Console;
Clear();

/*
Факториал N
*/

WriteLine(FactFor(10));
WriteLine(FactRec(10));

int FactFor(int n)
{
    int res = 1;
    for (int i = 1; i <= n; i++) res *= i;
    return res;
}

int FactRec(int n)
{
    if (n == 1) return 1;
    else return n * FactRec(n - 1);
}
