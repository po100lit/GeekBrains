# 1. Задайте список из нескольких чисел.
# Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.
# *Пример: *
# [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12
from random import randint as rd

random_list = [rd(1, 9) for _ in range(rd(3, 10))]  # генератор списка случайной длины из случайных чисел)))
print(random_list)  # можно эту строку убрать, но тогда мы не узнаем какой список был сгенерирован)))


def sum_odd_index_elements(numbers_list: list) -> int:
    sum_numbers = 0
    for i in range(1, len(numbers_list), 2):
        sum_numbers += numbers_list[i]
    return sum_numbers


def main():
    print(sum_odd_index_elements(random_list))


if __name__ == "__main__":
    main()
