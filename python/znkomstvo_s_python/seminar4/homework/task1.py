# Вычислить число c заданной точностью d.
# Число Пи не просто обрезать с math.pi, а вычислить, используя формулы:
# Нилаканта, ряды Тейлора, серию Ньютона или серию Чудновских.
# Пример:
# при d = 0.001, π = 3.141.    10^-10 ≤ d ≤ 10^-1
from math import pi


def nilakantha_pi() -> float:
    counted_pi = 3
    num1, num2, num3 = 2, 3, 4
    for i in range(100):
        counted_pi += 4 / (num1 * num2 * num3)
        num1 += 2
        num2 += 2
        num3 += 2
        counted_pi -= 4 / (num1 * num2 * num3)
        num1 += 2
        num2 += 2
        num3 += 2
    return counted_pi


calculated_pi = nilakantha_pi()


# проверку ввода не писал, надеясь на грамотность пользователя)))
def precision_pi(num: float) -> tuple[str, str]:
    precision = input('Введите точность округления в формате 0.001: ')
    round_num = len(precision.split('.')[1])
    return f'Real pi: {round(pi, round_num)}', f'My pi: {round(num, round_num)}'


def main():
    print(precision_pi(calculated_pi))


if __name__ == "__main__":
    main()
