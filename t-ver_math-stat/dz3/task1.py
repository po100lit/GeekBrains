# Даны значения зарплат из выборки выпускников:
# 100, 80, 75, 77, 89, 33, 45, 25, 65, 17, 30, 24, 57, 55, 70, 75, 65, 84, 90, 150.
# Посчитать (желательно без использования статистических методов наподобие std, var, mean)
# среднее арифметическое, среднее квадратичное отклонение, смещенную и несмещенную оценки дисперсий для данной выборки.


def average_arithmetic(lst):
    return sum(lst) / len(lst)


def numerator_standard_deviation(lst, avg):
    numerator = 0
    for i in lst:
        numerator += (i - avg) ** 2
    return numerator


def main():
    average_salary = [100, 80, 75, 77, 89, 33, 45, 25, 65, 17, 30, 24, 57, 55, 70, 75, 65, 84, 90, 150]
    answer_one = average_arithmetic(average_salary)
    print(f"среднее арифметическое: {answer_one}")
    answer_two = (numerator_standard_deviation(average_salary, answer_one) / len(average_salary)) ** 0.5
    print(f"среднее квадратичное отклонение: {answer_two}")
    answer_three = numerator_standard_deviation(average_salary, answer_one) / len(average_salary)
    print(f"смещённая дисперсия: {answer_three}")
    answer_four = numerator_standard_deviation(average_salary, answer_one) / (len(average_salary) - 1)
    print(f"несмещённая дисперсия: {answer_four}")


if __name__ == '__main__':
    main()
