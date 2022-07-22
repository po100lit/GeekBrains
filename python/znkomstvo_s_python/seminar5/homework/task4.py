# 4 Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных.
# Входные и выходные данные хранятся в отдельных текстовых файлах.
# При декодировании попробуйте сделать через четный-нечетный элемент.
from itertools import groupby


def read_file(filename: str) -> str:
    """
    Читает файл и возвращает считанную из него строку

    @param filename: имя файла
    @return: считанная из файла строка
    """
    with open(filename, 'r', encoding='utf-8') as file:
        result = file.read()
    return result


def compress_data(text: str) -> str:
    """
    Принимает строку, подсчитываем количество подряд идущих символов.
    Заменяет на строку вида "символ/количество повторов" (без разделителя)

    @param text: исходная строка с символами
    @return: сжатая строка символов
    """
    output_data = "".join([f"{i}{len(list(j))}" for i, j in groupby(text)])  # группируем символы/количеств подряд
    with open('task4_out.txt', 'w', encoding='utf-8') as file:  # сохраняем сжатую строку в файл
        file.write(output_data)
    return output_data


def decompress_data(text: str) -> str:
    """
    Принимает сжатую строку, переводит её в начальный вид.

    @param text: сжатая строка
    @return: 'распакованная' строка
    """
    letter = "".join(" " if el.isdigit() else el for el in text).split()  # список букв в сжатом тексте
    number = "".join(el if el.isdigit() else " " for el in text).split()  # список коэффициентов при буквах
    decompress_text = ''.join([x * y for x, y in zip(letter, map(int, number))])
    return decompress_text


def main():
    # программа "ломается", если в исходной строке содержатся цифры
    input_str = read_file('task4_in.txt')
    print('Исходный текст:', input_str)
    compressed_str = compress_data(input_str)
    print('Сжатый текст:', compressed_str)
    print('Коэффициент сжатия:', round(len(input_str)/len(compressed_str), 2))
    decompress_data(compressed_str)
    check_text = decompress_data(compressed_str)
    print('Строки обработаны без потерь:', check_text == input_str)  # сравнение input / decompress


if __name__ == "__main__":
    main()
