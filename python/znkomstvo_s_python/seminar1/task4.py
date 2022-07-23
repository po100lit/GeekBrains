# 2. Напишите программу, которая будет принимать на вход дробь и показывать первую цифру дробной части числа.
# *Примеры: *
# 6,78 -> 7
# 5 -> нет
# 0,34 -> 3

def main():
    num = None
    while True:
        try:
            num = float(input('Enter number: '))
        except ValueError:
            print('Неверный ввод')
        if num:
            break
    res = int(num * 10 % 10)
    if num - int(num) == 0:
        print('No')
    else:
        print(res)


if __name__ == "__main__":
    main()
