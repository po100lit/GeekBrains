# 4 - Определить, позицию второго вхождения строки в списке либо сообщить, что её нет.
# Примеры
# список: ["qwe", "asd", "zxc", "qwe", "ertqwe"], ищем: "qwe", ответ: 3
# список: ["йцу", "фыв", "ячс", "цук", "йцукен", "йцу"], ищем: "йцу", ответ: 5
# список: ["йцу", "фыв", "ячс", "цук", "йцукен"], ищем: "йцу", ответ: -1
# список: ["123", "234", 123, "567"], ищем: "123", ответ: -1
# список: [], ищем: "123", ответ: -1


def find_second_match(where_list: list, to_find: str) -> int:
    if len(list(filter(lambda x: x == to_find, where_list))) < 2:  # второе совпадение не найдено
        return -1
    else:
        return list(filter(lambda x: x[1] == to_find, list(enumerate(where_list))))[1][0]


def main():
    input_list = ["йцу", "фыв", "ячс", "цук", "йцукен", "йцу"]
    search_string = "йцу"
    print(find_second_match(input_list, search_string))


if __name__ == "__main__":
    main()
