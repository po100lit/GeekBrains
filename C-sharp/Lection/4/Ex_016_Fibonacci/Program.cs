using static System.Console;
Clear();

// ряд Фибоначи

double Fib(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fib(n - 1) + Fib(n - 2);
}

for (int i = 1; i < 30; i++) // i > 40 очень тормозит
{
    WriteLine($"f({i}) = {Fib(i)}");
}
