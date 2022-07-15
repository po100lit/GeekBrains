# 2. Напишите программу, которая найдёт произведение пар чисел списка.
# Парой считаем первый и последний элемент, второй и предпоследний и т.д.
# *Пример: *
# [2, 3, 4, 5, 6] = > [12, 15, 16];
# [2, 3, 5, 6] = > [12, 15]
from random import randint as rd

random_list = [rd(1, 9) for _ in range(rd(3, 10))]  # генератор списка случайной длины из случайных чисел)))
print(random_list)  # можно эту строку убрать, но тогда мы не узнаем какой список был сгенерирован)))


def sum_of_pairs(numbers_list: list) -> list:
    result_list = []
    first_index = 0
    last_index = len(numbers_list) - 1
    while last_index - first_index >= 0:
        result_list.append(numbers_list[first_index] * numbers_list[last_index])
        first_index += 1
        last_index -= 1
    return result_list


def main():
    print(sum_of_pairs(random_list))


if __name__ == "__main__":
    main()
