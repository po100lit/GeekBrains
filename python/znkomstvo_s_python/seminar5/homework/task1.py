# 1 Напишите программу, удаляющую из текста все слова, содержащие "абв".
# 'абвгдейка - это учёба и игра' => "- это передача"

def remove_words(text: str, contains: str) -> str:
    """
    Удаляем слова по маске

    @param text: текст из которого нужно удалить слова
    @param contains: маска для поиска в удаляемом слове
    @return: текст без слов, содержащих "маску"
    """
    temp_list = text.split()
    result_list = []
    for i in temp_list:
        if contains not in i:
            result_list.append(i)
    result = ' '.join(result_list)
    return result


def main():
    remove_words('абвгдейка - это учёба и игра', 'абв')


if __name__ == "__main__":
    main()
