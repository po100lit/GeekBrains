# 3. Напишите программу, в которой пользователь будет задавать две строки,
# а программа определять количество вхождений одной строки в другую, не используя метод .count()


def main():
    s1 = input('Введите 1 строку: ')
    s2 = input('Введите 2 строку: ')
    if len(s1) < len(s2):
        s1, s2 = s2, s1
    count = 0
    for i in range(0, len(s1) - len(s2)):
        if s2.lower() == s1[i:i + len(s2)].lower():
            count += 1
    print(count)


if __name__ == "__main__":
    main()
