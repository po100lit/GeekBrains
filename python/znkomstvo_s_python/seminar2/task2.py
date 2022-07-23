# 2. Для натурального n создать словарь индекс - значение, состоящий из элементов последовательности 3 n + 1.
# *Пример: *
# n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}

def main():
    n = None
    while True:
        try:
            n = int(input())
        except ValueError:
            print('Неверный ввод!')
        if n:
            break
    num_dict = {}
    for i in range(1, n+1):
        num_dict[i] = 3*i+1
    print(num_dict)


if __name__ == "__main__":
    main()
