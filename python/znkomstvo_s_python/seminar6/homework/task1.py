# 1 - Определить, присутствует ли в заданном списке строк, некоторое число


def get_match(string: str, num: str) -> bool:
    result = [x for x in string.split() if num in x]
    return len(result) > 0


def main():
    where_look_for = input('Введите исходную строку: ')
    what_look_for = input('Введите искомое число: ')
    print(get_match(where_look_for, what_look_for))


if __name__ == "__main__":
    main()
