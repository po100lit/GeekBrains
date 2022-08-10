import csv


def read_file(filename: str) -> dict:
    """
    Выгружает в память словарь с данными из CSV файла.

    :param filename: имя файла.
    :return: словарь.
    """
    result = {}
    try:
        with open(filename, 'r', encoding='utf-8') as file:
            reader = csv.reader(file, delimiter=',')
            for row in reader:
                result[int(row[0])] = {
                    'task': str(row[1]),
                    'is_done': int(row[2])
                }
    except FileNotFoundError:
        print('Файл не найден. Проверьте имя файла и/или путь к файлу.')
    return result


all_task = read_file('todo.csv')


def add_task(todo: dict, arg: str) -> str:
    todo_new = arg
    id_new = max(list(x for x in todo.keys())) + 1
    result_new = {
        'task': todo_new,
        'is_done': 0
    }
    todo[id_new] = result_new
    return f"Ваша задача < {todo_new} > добавлена."


def del_task(todo: dict, ID: str) -> str:
    try:
        del_id = abs(int(ID))
    except ValueError:
        return f"Wrong input"
    if del_id in todo.keys():
        del todo[del_id]
        return f"Ваша задача < {del_id} > удалена."
    else:
        return f'ID {del_id} не найден'



def save_data(todo: dict) -> str:
    with open('todo.csv', 'w', encoding='utf-8', newline='') as file:
        todo_save = csv.writer(file, delimiter=',')
        for k, v in todo.items():
            new_line = [k, v['task'], v['is_done']]
            todo_save.writerow(new_line)
    return 'Данные успешно сохранены!'



def print_todo(to_do: dict, done: int) -> str:
    """
    Вывод в консоль списка дел на основе переданного значения 'done'.

    :param to_do: словарь с данными.
    :param done: параметр match для печати соответствующих данных.
    :return: None.
    """
    tmp_list = []
    if done == 1:
        for key, value in to_do.items():
            tmp_list.append(f'ID {key} >>> {value["task"]} >>> {"Выполнено" if value["is_done"] else "Не выполнено"}')
        return '\n'.join(tmp_list)
    elif done == 2:
        for value in to_do.values():
            for k, v in value.items():
                if k == 'is_done' and v:
                    tmp_list.append(value['task'])
        return '\n'.join(tmp_list)
    elif done == 3:
        for value in to_do.values():
            for k, v in value.items():
                if k == 'is_done' and not v:
                    tmp_list.append(value['task'])
        return '\n'.join(tmp_list)
