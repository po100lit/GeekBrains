# 4 - Напишите программу, которая по заданному номеру четверти,
# показывает диапазон возможных координат точек в этой четверти (x и y).
from termcolor import cprint


def main():
    num = None
    possible_coordinates = {
        1: 'X ∈ (0, +∞), Y ∈ (0, +∞)',
        2: 'X ∈ (-∞, 0), Y ∈ (0, +∞)',
        3: 'X ∈ (-∞, 0), Y ∈ (-∞, 0)',
        4: 'X ∈ (0, +∞), Y ∈ (-∞, 0)'
    }
    while num not in range(1, 5):
        try:
            num = int(input('Введите номер четверти (1-4): '))
        except ValueError:
            cprint('Введите число!', 'red', attrs=['underline'])
    cprint(f'Возможные координаты точки в {num} четверти: {possible_coordinates[num]}', 'cyan')


if __name__ == "__main__":
    main()
