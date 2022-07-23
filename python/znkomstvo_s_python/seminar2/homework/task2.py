# 2 - Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.
# *Пример:*
# пусть N = 4, тогда [ 1, 2, 6, 24 ] (1, 1*2, 1*2*3, 1*2*3*4)

"""
Раз уж 'random' запретили, то и 'math' не будем использовать)))
"""


def factorial(number):
    if number == 0:
        return 1
    return number * factorial(number - 1)


def main():
    n = None
    while True:
        try:
            n = int(input('Введите натуральное число: '))
        except ValueError:
            print('Неверный ввод!')
        if n:
            break
    lst = []
    for i in range(1, n + 1):
        lst.append(factorial(i))
    print(lst)


if __name__ == "__main__":
    main()
