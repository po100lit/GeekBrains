# 2. Напишите программу, которая на вход принимает 5 чисел и находит максимальное из них.
# Примеры:
# 1, 4, 8, 7, 5 -> 8
# 78, 55, 36, 90, 2 -> 90

def main():
    lst = []
    num = None
    for i in range(5):
        while True:
            try:
                num = int(input('Введите целое число: '))
            except ValueError:
                print('Неверный ввод')
            if num:
                break
        lst.append(num)
    max_num = lst[0]
    for i in lst:
        if i > max_num:
            max_num = i
    print(max_num)


if __name__ == "__main__":
    main()
