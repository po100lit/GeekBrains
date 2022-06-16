using static System.Console;
Clear();

/*
Вывести сумму чисел от 1 до N
*/

WriteLine(SummFor(10));
WriteLine(SummRec(10));

int SummFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SummRec(int n)
{
    if (n == 0) return 0;
    else return n + SummRec(n - 1);
}
