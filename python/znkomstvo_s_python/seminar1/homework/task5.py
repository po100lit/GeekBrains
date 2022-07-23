# 5 - Напишите программу, которая принимает на вход координаты двух точек
# и находит расстояние между ними в 2D пространстве.
# *Пример:*
# A (3, 6); B (2, 1) -> 5,09
# A (7, -5); B (1, -1) -> 7,21
from termcolor import cprint


def main():
    coord_list = []
    for i in [1, 2]:
        for j in ['X', 'Y']:
            coord = None
            while True:
                try:
                    coord = float(input(f'Введите координату {j} точки {i}: '))
                except ValueError:
                    print('Неверный ввод!')
                if coord:
                    break
            coord_list.append(coord)
    result = ((coord_list[2] - coord_list[0]) ** 2 + (coord_list[3] - coord_list[1]) ** 2) ** 0.5
    cprint(f'Координаты первой точки: ({coord_list[0]}, {coord_list[1]})', 'yellow')
    cprint(f'Координаты второй точки: ({coord_list[2]}, {coord_list[3]})', 'yellow')
    cprint(f'Расстояние между точками: {round(result, 2)}', 'green')


if __name__ == "__main__":
    main()
