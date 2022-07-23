# 1. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
# *Примеры: *
# 5, 25 -> да
# 4, 16 -> да
# 25, 5 -> да
# 8, 9 -> нет

def main():
    a, b = None, None
    while True:
        try:
            a = int(input('Введите 1 число: '))
        except ValueError:
            print('Неверный ввод')
        if a:
            break
    while True:
        try:
            b = int(input('Введите 2 число: '))
        except ValueError:
            print('Неверный ввод')
        if b:
            break
    print(a ** 2 == b or b ** 2 == a)


if __name__ == "__main__":
    main()
