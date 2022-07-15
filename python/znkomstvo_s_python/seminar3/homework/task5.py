# 5. Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.
# *Пример: *
# для k = 8 список будет выглядеть так: [-21, 13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]
num_limit = 0
while num_limit < 1:
    try:
        num_limit = int(input("Введите натуральное число: "))
    except Exception as error:
        print(error)


def positive_fibonacci(num: int) -> list:
    positive_numbers = [0, 1]
    for i in range(1, num):
        positive_numbers.append(positive_numbers[-1] + positive_numbers[-2])
    return positive_numbers


def negative_fibonacci(num: int) -> list:
    negative_numbers = [0, 1]
    for i in range(1, num):
        negative_numbers.append(negative_numbers[-2] - negative_numbers[-1])
    return negative_numbers


def main():
    print(negative_fibonacci(num_limit)[::-1] + positive_fibonacci(num_limit)[1:])


if __name__ == "__main__":
    main()
