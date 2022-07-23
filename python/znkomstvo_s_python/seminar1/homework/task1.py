# 1 - Напишите программу, которая принимает на вход цифру,
# обозначающую день недели, и проверяет, является ли этот день выходным.
# *Пример:*
# 6 -> да
# 7 -> да
# 1 -> нет
from termcolor import cprint


def main() -> str:
    num = None
    days_dict = {
        1: 'понедельник',
        2: 'вторник',
        3: 'среда',
        4: 'четверг',
        5: 'пятница',
        6: 'суббота',
        7: 'воскресенье'
    }
    while num not in range(1, 8):
        try:
            num = int(input('Введите номер дня недели от 1 до 7: '))
        except ValueError:
            cprint('Неверный ввод!', 'red', attrs=['underline'])
    return f'{days_dict[num]} - выходной день' if num == 6 or num == 7 else f'{days_dict[num]} - будний день'


if __name__ == "__main__":
    print(main())
