# 5 - Найти произведение пар чисел в списке. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
from random import randint
from functools import reduce


def get_list() -> list:
    result_list = [randint(1, 9) for _ in range(randint(3, 7))]
    return result_list


def find_product(array: list) -> list:
    result_list = []
    start_i = 0
    end_i = len(array) - 1
    while end_i - start_i >= 0:
        result_list.append(reduce(lambda x, y: x * y, [array[start_i], array[end_i]]))
        start_i += 1
        end_i -= 1
    return result_list


def main():
    temp_list = get_list()  # Исходный список
    print(temp_list)
    result_list = find_product(temp_list)  # Список произведений соответствующих пар
    print(result_list)


if __name__ == "__main__":
    main()
