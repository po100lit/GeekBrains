# В текстовом файле удалить все слова, которые содержат хотя бы одну цифру.
# Например:
# Мама сшила м0не штаны и7з бере9зовой кор45ы 893. -> Мама сшила штаны.

input_string = 'Мама сшила м0не штаны и7з бере9зовой кор45ы 893'
print(input_string)


def remove_words_with_digit(string: str) -> str:
    temp_list = string.split()
    result = []
    for i in temp_list:
        if i.isalpha():
            result.append(i)
    return ' '.join(result)


def main():
    print(remove_words_with_digit(input_string))


if __name__ == "__main__":
    main()
