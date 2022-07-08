# 1 - Напишите программу, которая принимает на вход цифру,
# обозначающую день недели, и проверяет, является ли этот день выходным.
# *Пример:*
# 6 -> да
# 7 -> да
# 1 -> нет

def main():
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
        num = int(input('Введите номер дня недели от 1 до 7: '))
    if num == 6 or num == 7:
        print(f'{days_dict[num]} - выходной день')
    else:
        print(f'{days_dict[num]} - будний день')


if __name__ == "__main__":
    main()