#  Задать список из N элементов, заполненных числами из [-N, N].
#  Найти произведение элементов на указанных позициях.
#  Позиции хранятся в файле file.txt в одной строке одно число
n = None
while True:
    try:
        n = int(input('Введите число: '))
    except ValueError:
        print('Неверный ввод!')
    if n:
        break
my_list = [x for x in range(-n, n + 1)]
print(f'Исходный список {my_list}')


def product_elements(num_list: list) -> int:
    with open('file.txt') as file:
        indexes = file.read().split()
    print(f"Индексы {', '.join(indexes)}")
    product = 1
    for i in range(len(num_list)):
        if str(i) in indexes:
            product *= num_list[i]
    return product


def main():
    print(product_elements(my_list))


if __name__ == "__main__":
    main()
