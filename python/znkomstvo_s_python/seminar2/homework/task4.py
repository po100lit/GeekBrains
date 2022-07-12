# 4 - Реализуйте выдачу случайного числа (или алгоритм перемешивания списка)
# не использовать random.randint и вообще библиотеку random.
# Можете использовать xor, биты, библиотеку time (миллисекунды или наносекунды) - для задания случайности
import time


def random_number(from_number, to_number):  # в границы поиска мы никогда не попадём)))
    now = str(time.time())
    rnd = float(now[::-1][:3]) / 1000
    return int(from_number + rnd * (to_number - from_number))


def main():
    print(random_number(100, 1000))


if __name__ == "__main__":
    main()
