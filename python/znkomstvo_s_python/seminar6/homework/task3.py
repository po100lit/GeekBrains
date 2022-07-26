# 3 - Найти расстояние между двумя точками пространства (числа вводятся через пробел)
from functools import reduce


def get_distance(*args) -> float:
    # вычисляем корень суммы элементов {lambda a, b: (a + b) ** 0.5}
    # в списке из разности квадратов {(x - y) ** 2 for x, y in...}
    # в кортежах из соответствующих координат каждой точки list(zip(*args))
    # как-то сложно получилось в одну строку
    distance = reduce(lambda a, b: (a + b) ** 0.5, [(x - y) ** 2 for x, y in list(zip(*args))])
    return distance


def main():
    point_one = []
    point_two = []
    # Проверка ввода пользователя
    while True:
        try:
            point_one = list(map(float, input('Введите координаты 1 точки через пробел: ').split()))
        except ValueError:
            print('Wrong input')
        if len(point_one) == 2:
            break
    while True:
        try:
            point_two = list(map(float, input('Введите координаты 2 точки через пробел: ').split()))
        except ValueError:
            print('Wrong input')
        if len(point_two) == 2:
            break
    # выводит результат в консоль
    print(get_distance(point_one, point_two))


if __name__ == "__main__":
    main()
