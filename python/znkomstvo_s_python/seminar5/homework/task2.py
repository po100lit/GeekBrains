# 2 Создайте программу для игры с конфетами человек против человека.
# Условие задачи: На столе лежит 2021 конфета. Играют два игрока делая ход друг после друга.
# Первый ход определяется жеребьёвкой. За один ход можно забрать не более чем 28 конфет.
# Все конфеты оппонента достаются сделавшему последний ход.
# 1) Сколько конфет нужно взять первому игроку, чтобы забрать все конфеты у своего конкурента?
# 2) Добавьте игру против бота
# 3) Подумайте как наделить бота ""интеллектом""
from random import choice, randint


# 1) скорее на логику, чем на программирование)))
# игрок, желающий выиграть должен на предпоследнем ходу оставить (28 + 1) конфету
# или каждым своим ходом оставлять сопернику количество конфет, кратное (28 + 1)

def two_players_game_of_candies(candy_count: int, max_candy_takes: int) -> str:
    """
    Игра для двух игроков на конфеты.
    Игроки поочереди берут конфеты.
    Победитель забирает ВСЕ начальные конфеты.

    @param candy_count: Начальное количество конфет на столе
    @param max_candy_takes: Максимальное количество конфет, которые можно взять за 1 ход
    @return: Имя победителя
    """
    player_1 = input('Введите имя первого игрока: ')
    player_2 = input('Введите имя второго игрока: ')
    current_player = choice([player_1, player_2])  # Выбор кто ходит первым
    while candy_count > max_candy_takes:
        print(f'\nНа столе осталось {candy_count} конфет...')
        while True:
            try:
                take_candies = int(input(f'Сколько конфет берёт {current_player} (1-{max_candy_takes})?: '))
            except ValueError:
                print('Введите число')
            if 1 <= take_candies <= max_candy_takes:  # проверка, что игрок взял разрешенное количество конфет
                break
        candy_count -= take_candies
        current_player = player_2 if current_player == player_1 else player_1
    print(f'{current_player} забрал последние {candy_count} конфет и ПОБЕДИЛ!')
    print(f'{current_player} получает все конфеты {player_2 if current_player == player_1 else player_1}')
    return current_player


def player_vs_npc_game_of_candies(candy_count: int, max_candy_takes: int) -> str:
    """
    Игра для игрока и компьютера на конфеты. Компьютер не знает выигрышную стратегию.
    Игроки поочереди берут конфеты.
    Победитель забирает ВСЕ начальные конфеты.

    @param candy_count: Начальное количество конфет на столе
    @param max_candy_takes: Максимальное количество конфет, которые можно взять за 1 ход
    @return: Имя победителя
    """
    player_1 = input('Введите имя первого игрока: ')
    player_2 = 'John Doe'
    current_player = choice([player_1, player_2])  # Выбор кто ходит первым
    while candy_count > max_candy_takes:
        print(f'\nНа столе осталось {candy_count} конфет...')
        while True:
            if current_player == player_1:
                try:
                    take_candies = int(input(f'Сколько конфет берёт {current_player} (1-{max_candy_takes})?: '))
                except ValueError:
                    print('Введите число')
            else:
                take_candies = randint(1, max_candy_takes)
                print(f'{current_player} берёт {take_candies} конфет')
            if 1 <= take_candies <= max_candy_takes:  # проверка, что игрок взял разрешенное количество конфет
                break
        candy_count -= take_candies
        current_player = player_2 if current_player == player_1 else player_1
    print(f'{current_player} забрал последние {candy_count} конфет и ПОБЕДИЛ!')
    print(f'{current_player} получает все конфеты {player_2 if current_player == player_1 else player_1}')
    return current_player


def AI_vs_player_game_of_candies_v1(candy_count: int, max_candy_takes: int) -> str:
    """
    Игра для игрока и компьютера на конфеты. * Компьютер знает выигрышную стратегию, а игрок - нет)))
    Игроки поочереди берут конфеты.
    Победитель забирает ВСЕ начальные конфеты.

    @param candy_count: Начальное количество конфет на столе
    @param max_candy_takes: Максимальное количество конфет, которые можно взять за 1 ход
    @return: Имя победителя
    """
    player_1 = input('Введите имя первого игрока: ')
    player_2 = 'John Doe'
    current_player = choice([player_1, player_2])  # Выбор кто ходит первым
    while candy_count > max_candy_takes:
        print(f'\nНа столе осталось {candy_count} конфет...')
        while True:
            if current_player == player_1:
                try:
                    take_candies = int(input(f'Сколько конфет берёт {current_player} (1-{max_candy_takes}): '))
                except ValueError:
                    print('Введите число')
            # компьютер прикидывается дурачком и предпоследним ходом не оставляет шансов игроку победить
            else:
                if (max_candy_takes + 1) < candy_count <= (max_candy_takes * 2 + 1):
                    take_candies = abs(max_candy_takes + 1 - candy_count)
                else:
                    take_candies = randint(1, max_candy_takes)
                print(f'{current_player} берёт {take_candies} конфет')
            if 1 <= take_candies <= max_candy_takes:  # проверка, что игрок взял разрешенное количество конфет
                break
        candy_count -= take_candies
        current_player = player_2 if current_player == player_1 else player_1
    print(f'{current_player} забрал последние {candy_count} конфет и ПОБЕДИЛ!')
    print(f'{current_player} получает все конфеты {player_2 if current_player == player_1 else player_1}')
    return current_player


def AI_vs_player_game_of_candies_v2(candy_count: int, max_candy_takes: int) -> str:
    """
    Игра для игрока и компьютера на конфеты. * Компьютер знает выигрышную стратегию, а игрок - нет)))
    Игроки поочереди берут конфеты.
    Победитель забирает ВСЕ начальные конфеты.

    @param candy_count: Начальное количество конфет на столе
    @param max_candy_takes: Максимальное количество конфет, которые можно взять за 1 ход
    @return: Имя победителя
    """
    player_1 = input('Введите имя первого игрока: ')
    player_2 = 'John Doe'
    current_player = choice([player_1, player_2])  # Выбор кто ходит первым
    while candy_count > max_candy_takes:
        print(f'\nНа столе осталось {candy_count} конфет...')
        while True:
            if current_player == player_1:
                try:
                    take_candies = int(input(f'Сколько конфет берёт {current_player} (1-{max_candy_takes}): '))
                except ValueError:
                    print('Введите число')
            # компьютер каждым своим ходом лишает игрока шанса на победу
            else:  # остаток конфет после хода компьютера всегда будет кратен {max_candy_takes + 1}
                take_candies = candy_count - (candy_count // (max_candy_takes + 1)) * (max_candy_takes + 1)
                if take_candies == 0:  # игрок (случайно) оставил боту кратно {max_candy_takes + 1} конфет)))
                    print(f'Ты знаешь выигрышную стратегию?...')
                    take_candies = randint(1, 28)
                    print(f'{current_player} берёт {take_candies} конфет')
                else:
                    print(f'{current_player} берёт {take_candies} конфет')
            if 1 <= take_candies <= max_candy_takes:  # проверка, что игрок взял разрешенное количество конфет
                break
        candy_count -= take_candies
        current_player = player_2 if current_player == player_1 else player_1
    print(f'{current_player} забрал последние {candy_count} конфет и ПОБЕДИЛ!')
    print(f'{current_player} получает все конфеты {player_2 if current_player == player_1 else player_1}')
    return current_player


def main():
    # two_players_game_of_candies(2021, 28)
    player_vs_npc_game_of_candies(2021, 28)
    # AI_vs_player_game_of_candies_v1(2021, 28)
    # AI_vs_player_game_of_candies_v2(2021, 28)


if __name__ == "__main__":
    main()
