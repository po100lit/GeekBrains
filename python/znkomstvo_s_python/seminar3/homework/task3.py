# 3. Задайте список из вещественных чисел.
# Напишите программу, которая найдёт разницу между максимальным и минимальным значением дробной части элементов.
# *Пример: *
# [1.1, 1.2, 3.1, 5, 10.01] = > 0.19
from random import randint as rd

input_list = [rd(1, 100) + rd(10, 99) / 100 for _ in range(rd(2, 10))]  # генерируем список дробных чисел
print(input_list)  # можно эту строку убрать, но тогда мы не узнаем какой список был сгенерирован)))


def get_fraction(number: float) -> float:
    return round(number - int(number), 2)


def find_difference(numbers_list: list) -> float:
    min_value = max_value = get_fraction(numbers_list[0])
    for number in numbers_list:
        max_value = max(max_value, get_fraction(number))
        min_value = min(min_value, get_fraction(number))
    print(f'{max_value} - {min_value}')  # максимальная и минимальная дробные части
    return round(max_value - min_value, 2)


def main():
    print(find_difference(input_list))


if __name__ == "__main__":
    main()
