# В текстовом файле удалить все слова, которые содержат хотя бы одну цифру.
# Например:
# Мама сшила м0не штаны и7з бере9зовой кор45ы 893. -> Мама сшила штаны.

def read_string(filepath: str) -> str:
    with open(f'{filepath}', 'r', encoding='utf-8') as file:
        string = file.read()
        return string


input_string = read_string('task4.txt')
print(input_string)


def remove_words_with_digit(string: str) -> str:
    temp_list = string.split()
    result = []
    for i in temp_list:
        if i.isalpha():
            result.append(i)
    return ' '.join(result)


output_string = remove_words_with_digit(input_string)


def save_file(filepath: str):
    with open(f'{filepath}', 'w', encoding='utf-8') as file:
        file.write(output_string)


def main():
    print(output_string)
    save_file('new_task4.txt')


if __name__ == "__main__":
    main()
