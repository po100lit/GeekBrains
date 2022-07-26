# 2 - Найти сумму чисел списка стоящих на нечетной позиции
from random import randint
from functools import reduce


def sum_odd_index() -> int:
    lst = [randint(1, 100) for _ in range(randint(3, 9))]
    filtered_list = list(x[1] for x in enumerate(lst) if x[0] % 2)  # {x[0] % 2} вернёт True, если число нечётное
    odd_sum = reduce(lambda x, y: x + y, filtered_list)
    return odd_sum


def main():
    print(sum_odd_index())


if __name__ == "__main__":
    main()
