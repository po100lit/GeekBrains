# 3 - Напишите программу, которая принимает на вход координаты точки (X и Y),
# причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
# в которой находится эта точка (или на какой оси она находится).
# *Пример:*
# x=34; y=-30 -> 4
# x=2; y=4-> 1
# x=-34; y=-30 -> 3
from termcolor import cprint


def main():
    x, y = 0, 0
    while x == 0:
        try:
            x = float(input('Введите координату X не равную нулю: '))
        except ValueError:
            cprint('Введите число!', 'red', attrs=['underline'])
    while y == 0:
        try:
            y = float(input('Введите координату Y не равную нулю: '))
        except ValueError:
            cprint('Введите число!', 'red', attrs=['underline'])
    if x > 0 and y > 0:
        cprint('точка находится в I четверти', 'blue')
    elif x < 0 < y:
        cprint('точка находится в II четверти', 'yellow')
    elif x < 0 and y < 0:
        cprint('точка находится в III четверти', 'magenta')
    else:
        cprint('точка находится в IV четверти', 'yellow')


if __name__ == "__main__":
    main()
