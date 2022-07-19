# 3. Задайте строку из набора чисел.
# Напишите программу, которая покажет большее и меньшее число.
# В качестве символа-разделителя используйте пробел.

my_list = list(map(int, input('Введите числа через пробел: ').split()))


def find_max_min(array: list) -> tuple:
    max_num = array[0]
    min_num = array[0]
    for num in array:
        max_num = max(max_num, num)
        min_num = min(min_num, num)
    return max_num, min_num


def main():
    print(find_max_min(my_list))


if __name__ == "__main__":
    main()
