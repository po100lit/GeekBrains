# 2. Напишите программу, которая определит позицию второго вхождения строки в списке либо сообщит, что её нет.
# ['a', 'a','b'] -> 'a' по индексу 1

def main():
    test_list = ['a', 'c', 'b', 'a']
    letter = 'a'
    k = 0
    for i in range(len(test_list)):
        if test_list[i] == letter:
            k += 1
            if k == 2:
                return i
    else:
        return None


if __name__ == "__main__":
    print(main())
