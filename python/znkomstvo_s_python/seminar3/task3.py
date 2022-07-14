#  Задать список из N элементов, заполненных числами из [-N, N].
#  Найти произведение элементов на указанных позициях.
#  Позиции хранятся в файле file.txt в одной строке одно число

def main():
    n = int(input('Введите число: '))
    my_list = [x for x in range(-n, n + 1)]
    print(f'Исходный список {my_list}')
    with open('file.txt') as file:
        res = file.read().split()
    print(f"Индексы {', '.join(res)}")
    product = 1
    for i in range(len(my_list)):
        if str(i) in res:
            product *= my_list[i]
    return f'Произведение элементов с заданными индексами {product}'


if __name__ == "__main__":
    print(main())
