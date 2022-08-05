import csv
import json


def load_tasks(filename: str) -> dict:
    """
    Convert CSV to dictionary

    :param filename: string
    :return: dictionary
    """
    result = {}
    with open(filename, 'r', encoding='utf-8') as file:
        reader = csv.reader(file, delimiter=',')
        for row in reader:
            result[int(row[0])] = {
                'task': str(row[1]),
                'is_done': int(row[2])
            }
    return result


def load_phones(filename: str) -> dict:
    """
    Convert CSV to dictionary

    :param filename: string
    :return: dictionary
    """
    result = {}
    with open(filename, 'r', encoding='utf-8') as file:
        reader = csv.reader(file, delimiter=',')
        for row in reader:
            result[int(row[0])] = {
                'surname': str(row[1]),
                'name': str(row[2]),
                'phone': str(row[3])
            }
    return result


all_tasks = json.dumps(load_tasks('todo.csv'), indent=4, ensure_ascii=False)
all_phones = json.dumps(load_phones('phones.csv'), indent=4, ensure_ascii=False)
