# 1. Задайте список. Напишите программу, которая определит, присутствует ли в заданном списке строк некое число.
# [',hfh5', '5', 'dfgh']

def main():
    num_to_find = 6
    str_list = [',hfh5', '5', 'dfgh']
    for i in range(len(str_list)):
        return str(num_to_find) in str_list[i]


if __name__ == "__main__":
    print(main())
