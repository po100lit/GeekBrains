# 2. Напишите программу, которая определит позицию второго вхождения строки в списке либо сообщит, что её нет.
# ['a', 'a','b'] -> 'a' по индексу 1

def find_symbol(symbol: str) -> int or None:
    test_list = ['a', 'c', 'b', 'a']
    k = 0
    for i in range(len(test_list)):
        if test_list[i] == symbol:
            k += 1
            if k == 2:
                return i
    else:
        return None


def main():
    print(find_symbol('a'))


if __name__ == "__main__":
    main()
