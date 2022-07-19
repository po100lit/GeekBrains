# 1. Задайте список из N элементов, заполненных числами из промежутка [-N, N].
# Найдите произведение элементов на указанных позициях.
# Позиции хранятся в файле file.txt в одной строке одно число.
from random import randint


def product_elements() -> int:
    with open('indexes.txt', 'r', encoding='utf-8') as file:
        indexes = file.read().split('\n')
    n = int(input('Введите длину списка: '))
    my_list = []
    for i in range(n):
        my_list.append(randint(-n, n))
    print('Исходный список: ', my_list)
    print('Индексы множителей: ', ', '.join(indexes))
    product = 1
    for i in range(len(my_list)):
        if str(i) in indexes:
            product *= my_list[i]
    return product


def main():
    print('Произведение нужных элементов: ', product_elements())


if __name__ == "__main__":
    main()
