# 1. Задайте список. Напишите программу, которая определит, присутствует ли в заданном списке строк некое число.
# [',hfh5', '5', 'dfgh']

def find_num(number: int) -> bool:
    str_list = [',hfh5', '5', 'dfgh']
    for i in range(len(str_list)):
        return str(number) in str_list[i]


def main():
    print(find_num(5))


if __name__ == "__main__":
    main()
