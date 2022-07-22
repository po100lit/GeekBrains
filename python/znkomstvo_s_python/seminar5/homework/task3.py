# 3 Создайте два списка — один с названиями языков программирования, другой — с числами от 1 до длины первого.
# ['python', 'c#']
# [1,2]
# Вам нужно сделать две функции:
# - первая создаст список кортежей, состоящих из номера и языка, написанного большими буквами.
# [(1,'PYTHON'), (2,'C#')]
# - вторая отфильтрует этот список следующим образом:
# * если сумма очков слова имеет в делителях номер, с которым она в паре в кортеже,
# * то кортеж остается, его номер заменяется на сумму очков.
# [сумма очков c# = 1092, в делителях есть 2 с которым в паре. Значит список будет]
# [(1,'PYTHON'), (1092,'C#')]
# * если нет — удаляется.
# Суммой очков называется сложение порядковых номеров букв в слове.
# Порядковые номера смотрите в этой таблице, в третьем столбце: https://www.charset.org/utf-8
# Это шестнадцатеричная система, поищите, как правильнее и быстрее получать эти символы.
# С помощью reduce сложите получившиеся числа и верните из функции в качестве ответа.
from functools import reduce


def generate_list_of_tuples(lst: list) -> list:
    result = list(enumerate(lst, 1))
    print('Список кортежей:', result)  # служебный принт
    return result


def filter_list(lst: list) -> list:
    result_list = []
    for i in lst:
        sum_of_letters = 0
        for letter in i[1]:
            sum_of_letters += ord(letter)
        if sum_of_letters % i[0] == 0:
            result_list.append((sum_of_letters, i[1]))
    print('Отфильтрованный список:', result_list)  # служебный принт
    return result_list


def sum_of_point(lst: list) -> int:
    result = reduce(lambda x, y: x + y, [x[0] for x in lst])
    print('Сумма очков слов:', result)  # служебный принт
    return result


def main():
    # www.charset.org/utf-8 у меня (в Казахстане) почему-то не открывается, порядковые номера беру из ord()
    programing_languages = ['python', 'java', 'swift', 'php', 'ruby', 'C++', 'kotlin']
    list_with_points = generate_list_of_tuples(programing_languages)
    result_list = filter_list(list_with_points)
    sum_of_point(result_list)


if __name__ == "__main__":
    main()
