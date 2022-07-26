# 6 - Сформировать список из N членов последовательности.
# Для N = 5: 1, -3, 9, -27, 81 и т.д.


def get_sequence(length: int) -> list:
    return list(map(lambda x: (-3) ** x, [exponent for exponent in range(length)]))


def main():
    n = 0
    while n < 1:
        try:  # Проверка ввода пользователя.
            n = int(input('Введите целое число > 0: '))
        except ValueError:
            print('Wrong input. Please try again...')
    print(get_sequence(n))  # Печать списка


if __name__ == "__main__":
    main()
