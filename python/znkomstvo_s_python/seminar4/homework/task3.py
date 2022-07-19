# 3. Задайте натуральное число N.
# Напишите программу, которая составит список простых множителей числа N.
# Пример: при N = 12 -> [2, 3]
import random

number = random.randint(2, 10000000)


def is_prime(num: int) -> bool:  # проверка числа на простоту
    for i in range(2, int(num ** 0.5 + 1)):
        if num % i == 0:
            return False
    return True


def get_prime_divisors(num: int) -> list:  # поиск простых делителей числа
    prime_divisors = []
    for i in range(2, int(num // 2 + 1)):
        if num % i == 0 and is_prime(i):
            prime_divisors.append(i)
    if len(prime_divisors) == 0:
        print('Число простое... простые делители единица и само число')
    return prime_divisors


def main():
    print(f'Исходное число: {number}')
    print(f'Простые делители:', ', '.join(list(map(str, get_prime_divisors(number)))))


if __name__ == "__main__":
    main()
