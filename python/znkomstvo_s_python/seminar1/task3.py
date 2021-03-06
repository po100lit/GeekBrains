# 1. Напишите программу, которая будет на вход принимать число N и выводить числа от - N до N
# *Примеры: *
# 5 -> -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5

def main():
    num = None
    while True:
        try:
            num = int(input('Введите целое число: '))
        except ValueError:
            print('Неверный ввод')
        if num:
            break
    if num < 0:
        num *= -1
    lst = []
    for i in range(-num, num+1):
        lst.append(i)
    print(lst)


if __name__ == "__main__":
    main()
