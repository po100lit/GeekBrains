from sympy import *


def main():
    x = Symbol('x', real=True)
    y = Function('x')

    y = x ** 2 - 6 * abs(x) + 8
    print(f'уравнение: {y}')

    roots = solve(y, x)
    print(f'корни уравнения {roots}')

    derive = diff(y)
    print(f'производная: {derive}')

    d_roots = solve(derive, x)
    d_roots.append(d_roots[0] * -1)
    print(f'корни производной {d_roots}')

    infinity = oo
    print(type(infinity))


if __name__ == "__main__":
    main()
