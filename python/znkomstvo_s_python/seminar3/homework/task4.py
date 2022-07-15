# 4. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
# *Пример: *
# 45 -> 101101
# 3 -> 11
# 2 -> 10

def decimal_to_bin(number: int) -> str:
    binary_number = ''
    while number > 0:
        binary_number += str(number % 2)
        number //= 2
    return binary_number[::-1]


def main():
    print(decimal_to_bin(45))
    print(decimal_to_bin(3))
    print(decimal_to_bin(2))


if __name__ == "__main__":
    main()
