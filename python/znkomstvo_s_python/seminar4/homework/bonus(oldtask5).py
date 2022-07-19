# Сумма многочленов
# !!! корректно работает если все коэффициенты целые числа > 0 и максимальные степени обоих многочленов равны
# TODO: программа должна понимать коэффициенты <= 0 и работать с разными максимальными степенями многочленов


def read_files(file1: str, file2: str) -> tuple[str, str]:
    try:
        with open(file1) as file:
            string1 = file.read()
    except FileNotFoundError:
        exit(f'Файл {file1} не найден! Проверьте имя файла и/или путь к файлу')
    try:
        with open(file2) as file:
            string2 = file.read()
    except FileNotFoundError:
        exit(f'Файл {file2} не найден! Проверьте имя файла и/или путь к файлу')
    return string1, string2


str1 = read_files('polynom1.txt', 'polynom2.txt')[0]
str2 = read_files('polynom1.txt', 'polynom2.txt')[1]
print(str1)  # вспомогательный принт
print(str2)  # вспомогательный принт
print('-' * 30)  # вспомогательный принт


def clear_signs(string: str) -> tuple[list, int]:
    ratio_no_x = int(string[string.rfind('+') + 1: string.rfind('=')].strip())  # коэффициент при X^0
    string = string[:string.rfind('x') + 1].replace(' + ', ' ')  # убираем правую часть уравнения, плюсы и пробелы
    result_list = string.split()
    return result_list, ratio_no_x


polynom1 = clear_signs(str1)[0]
polynom2 = clear_signs(str2)[0]
ratio1 = clear_signs(str1)[1]
ratio2 = clear_signs(str2)[1]


def sum_polynomial(list1: list, list2: list, ratio_1: int, ratio_2: int) -> str:  # складываем
    result = []
    for i in range(len(list1)):
        power_x1 = list1[i][list1[i].find('*'):]  # степень при X
        ratio_x1 = int(list1[i][:list1[i].find('*')])  # коэффициент при X
        for j in range(len(list2)):
            power_x2 = list2[j][list2[j].find('*'):]  # Степень при X
            ratio_x2 = int(list2[j][:list2[j].find('*')])  # коэффициент при X
            if power_x1 == power_x2:  # фактически сравниваем строки '*x^{n}', подразумевая '{n}'
                result.append((str(ratio_x1 + ratio_x2) + power_x1))
    return ' + '.join(result) + f' + {ratio_1 + ratio_2} = 0'


result = sum_polynomial(polynom1, polynom2, ratio1, ratio2)


def main():
    print(result)  # вспомогательный принт
    with open('sum_polynomials.txt', 'w', encoding='utf-8') as file:
        file.write(result)


if __name__ == "__main__":
    main()
