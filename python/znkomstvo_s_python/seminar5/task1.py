# Задана натуральная степень n.
# Сформировать случайным образом список коэффициентов (от 0 до 100) многочлена и записать в файл многочлен степени n.
# *Пример:
# n=2 => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 или 10*x² = 0
# n =3  => x**4 + 8*x**3 + 2*x² + 4*x + 5 = 0
# Все коэффициенты кроме нулевого могут быть нулем - такого элемента в полиноме не будет
# если коэффициент равен 1, то 1 указывается только при свободном элементе.При x² + 5 = 0  - это 5.

import random

d = {  # словарь для подмены показателей степени, например x⁵ вместо x^5
    1: '\u00B9',
    2: '\u00B2',
    3: '\u00B3',
    4: '\u2074',
    5: '\u2075',
    6: '\u2076',
    7: '\u2077',
    8: '\u2078',
    9: '\u2079'
}


def get_polynomial() -> list:
    k = random.randint(2, 9)  # максимальный показатель степени многочлена
    term_list = []
    for i in range(k, 0, -1):
        term_list.append(f'{random.randint(0, 100)}x{d[k]}')
        k -= 1
    term_list.append(str(random.randint(0, 100)))
    for index in range(len(term_list) - 1, -1, -1):
        if term_list[index].startswith('0'):
            term_list.remove(term_list[index])  # удаляем элемент с коэффициентом = 0
        elif term_list[index].startswith('1x'):
            term_list[index] = term_list[index][1:]  # убираем из записи коэффициент = 1
        elif term_list[index].endswith('x\u00B9'):
            term_list[index] = term_list[index].replace('x\u00B9', 'x')  # убираем из записи показатель степени = 1
    return term_list


def generate_result(array: list) -> str:
    result = ' + '.join(array) + ' = 0'
    return result


def main():
    polynomial = get_polynomial()
    string_to_write = generate_result(polynomial)
    print(string_to_write)  # вспомогательный принт
    with open('task1.txt', 'w', encoding='utf-8') as file:
        file.write(string_to_write)


if __name__ == '__main__':
    main()
