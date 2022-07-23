# 1. Напишите программу, которая принимает на вход число N и выдаёт последовательность из N членов.
# *Пример: *
# N = 5: 1, -3, 9, -27, 81


def main():
    n = None
    while True:
        try:
            n = int(input('Enter number: '))
        except ValueError:
            print('Неверный ввод!')
        if n:
            break
    for i in range(0, n):
        print((-3) ** i, end=' ')


if __name__ == "__main__":
    main()
