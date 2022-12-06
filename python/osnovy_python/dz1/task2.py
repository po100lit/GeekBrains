# На складе лежат разные фрукты в разном количестве.
# Нужно написать функцию, которая на вход принимает любое количество названий фруктов и их количество,
# а возвращает общее количество фруктов на складе


def fruit_count(**count):
    all_fruit_count = 0
    for k in count.keys():
        all_fruit_count += count[k]
    print(f'Всего фруктов на складе: {all_fruit_count}')


def main():
    fruit_count(apples=10)
    fruit_count(apples=10, bananas=15)
    fruit_count(apples=10, bananas=15, pears=22)


if __name__ == "__main__":
    main()
