# 4. Задайте два числа.
# Напишите программу, которая найдёт НОК (наименьшее общее кратное) этих двух чисел.

def find_smallest_common_multiple(num1: int, num2: int) -> int:
    scm = min(num1, num2)
    while True:
        if scm % num1 == 0 and scm % num2 == 0:
            break
        scm += 1
    return scm


def main():
    print(find_smallest_common_multiple(4, 18))


if __name__ == "__main__":
    main()
