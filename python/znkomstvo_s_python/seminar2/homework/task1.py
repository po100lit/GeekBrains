# 1 - Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.
# *Пример:*
# 6782 -> 23
# 0,56 -> 11

def main():
    n = None
    while True:
        try:
            n = float(input('Введите вещественное число: '))
        except ValueError:
            print('Неверный ввод!')
        if n:
            break
    n = str(n).replace('.', '').replace('-', '')
    result = sum(map(int, n))
    print(result)


if __name__ == "__main__":
    main()
