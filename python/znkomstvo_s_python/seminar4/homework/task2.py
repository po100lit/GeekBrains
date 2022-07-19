# 2. Задайте последовательность чисел.
# Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности.
# Посмотрели, что такое множество? Вот здесь его не используйте.
import random


def generate_list() -> list:
    my_list = [random.randint(10, 25) for x in range(random.randint(5, 10))]
    return my_list


new_list = generate_list()


def check_duplicates(array: list) -> list:
    result = []
    for num in array:
        if array.count(num) == 1:
            result.append(num)
    return result


def main():
    print(new_list)
    print(check_duplicates(new_list))


if __name__ == '__main__':
    main()
