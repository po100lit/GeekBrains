# Создать калькулятор для работы с рациональными и комплексными числами.
# Организовать меню, добавив в неё систему логирования.
import logging


def start_log():
    logging.basicConfig(filename='log.log',
                        level=logging.DEBUG,
                        datefmt='%Y.%m.%d %H:%M:%S',
                        format='%(asctime)s - %(name)s - %(levelname)s: %(message)s')


if __name__ == '__main__':
    start_log()
