# 2 - Напишите программу для проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.

def main():
    print(f'X\t\tY\t\tZ\t\tresult')
    print('-' * 30)
    for x in [True, False]:
        for y in [True, False]:
            for z in [True, False]:
                print(f'{x}\t{y}\t{z}\t{not (x or y or z) == (not x and not y and not z)}')


if __name__ == "__main__":
    main()
