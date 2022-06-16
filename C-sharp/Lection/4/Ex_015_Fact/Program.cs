using static System.Console;
Clear();

// факториал через рекурсию

double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

for (int i = 1; i < 20; i++)
{
    WriteLine($"{i}! = {Factorial(i)}");
}
