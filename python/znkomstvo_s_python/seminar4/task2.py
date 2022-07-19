# 2. Создать и заполнить файл случайными целыми значениями.
# Выполнить сортировку содержимого файла по возрастанию.
# (не использовать sort и sorted)
from random import randint


def generate_indexes():
    lst = [randint(10, 99) for _ in range(5)]
    with open('numbers.txt', 'w', encoding='utf-8') as file:
        file.write(' '.join(list(map(str, lst))))


with open('numbers.txt', 'r', encoding='utf-8') as file:
    data = file.read()
my_list = list(map(int, data.split()))
print(my_list)


def sort_list(array: list) -> list:
    swap = True
    while swap:
        swap = False
        for i in range(len(array) - 1):
            if array[i] > array[i + 1]:
                array[i], array[i + 1] = array[i + 1], array[i]
                swap = True
    return array


sorted_list = sort_list(my_list)


def main():
    generate_indexes()
    print(sorted_list)


if __name__ == "__main__":
    main()
