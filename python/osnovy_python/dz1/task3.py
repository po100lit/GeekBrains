# Дан список с затратами на рекламу. Но в данных есть ошибки, некоторые затраты имеют отрицательную величину.
# Удалите такие значения из списка и посчитайте суммарные затраты
# [100, 125, -90, 345, 655, -1, 0, 200]
# Используйте list comprehensions

def main():
    input_data = [100, 125, -90, 345, 655, -1, 0, 200]
    expenses = [i for i in input_data if i >= 0]
    print(f'Затраты на рекламу: {sum(expenses)}')


if __name__ == "__main__":
    main()
