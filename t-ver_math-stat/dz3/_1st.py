# Даны значения зарплат из выборки выпускников:
# 100, 80, 75, 77, 89, 33, 45, 25, 65, 17, 30, 24, 57, 55, 70, 75, 65, 84, 90, 150.
# Посчитать (желательно без использования статистических методов наподобие std, var, mean)
# среднее арифметическое, среднее квадратичное отклонение, смещенную и несмещенную оценки дисперсий для данной выборки.


def average_arithmetic(lst):
    return sum(lst) / len(lst)


def standard_deviation(lst, avg):
    numerator = 0
    for i in lst:
        numerator += (i - avg) ** 2
    return round((numerator / len(lst)) ** 0.5, 2)


def main():
    average_salary = [100, 80, 75, 77, 89, 33, 45, 25, 65, 17, 30, 24, 57, 55, 70, 75, 65, 84, 90, 150]
    answer_one = average_arithmetic(average_salary)
    print(f"среднее арифметическое: {answer_one}")
    answer_two = standard_deviation(average_salary, answer_one)
    print(f"среднее квадратичное отклонение: {answer_two}")


if __name__ == '__main__':
    main()
