from telegram.ext import Updater, CommandHandler, Filters, MessageHandler, ConversationHandler
import os
from random import randint, choice

game = False
candy_count = 300
max_candy_takes = 28
token = os.getenv('TOKEN')
PLAYER, MOVE = range(2)
player_1 = ''
player_2 = 'John Doe'
current_player = None

updater = Updater(token)
dispatcher = updater.dispatcher
print('Бот работает...')


def start(update, context):
    global game
    arg = context.args
    if not arg:
        context.bot.send_message(update.effective_chat.id, f"Привет! Давай сыграем с тобой в игру!\n"
                                                           f"у меня есть {candy_count} конфет,"
                                                           f" за один ход можно взять не более {max_candy_takes}\n"
                                                           f"кто заберет последние конфеты - тот выиграл")
        game = True
    context.bot.send_message(update.effective_chat.id, 'Представься, пожалуйста!')
    return PLAYER


def player_name(update, context):
    global player_1, current_player
    player_1 = update.message.text.title()
    current_player = choice([player_1, player_2])  # Выбор кто ходит первым
    context.bot.send_message(update.effective_chat.id, f'Первым ходит {current_player}')
    if current_player != player_1:
        bot_move(update, context)
    context.bot.send_message(update.effective_chat.id, f'Сколько конфет берёт {current_player}: ')
    return MOVE


def take_move(update, context):
    global candy_count, current_player
    try:
        take_candies = int(update.message.text)
        if 1 <= take_candies <= max_candy_takes:
            candy_count -= take_candies
        else:
            context.bot.send_message(update.effective_chat.id, f'За раз можно взять {max_candy_takes} конфет')
    except:
        context.bot.send_message(update.effective_chat.id, f'Введите число')
        return
    context.bot.send_message(update.effective_chat.id, f'На столе осталось {candy_count} конфет...')
    if candy_count < max_candy_takes:
        context.bot.send_message(update.effective_chat.id, f'Победил {current_player}')
        return ConversationHandler.END
    current_player = player_2 if current_player == player_1 else player_1
    bot_move(update, context)
    if candy_count < max_candy_takes:
        context.bot.send_message(update.effective_chat.id, f'Победил {current_player}')
        return ConversationHandler.END

# TODO: пропуск хода если не верное количество конфет
# TODO: не правильный выигрыш

def bot_move(update, context):
    global candy_count, current_player
    if (max_candy_takes + 1) < candy_count <= (max_candy_takes * 2 + 1):
        take_candies = abs(max_candy_takes + 1 - candy_count)
    else:
        take_candies = randint(1, max_candy_takes)
    candy_count -= take_candies
    context.bot.send_message(update.effective_chat.id, f'{current_player} берёт {take_candies} конфет')
    context.bot.send_message(update.effective_chat.id, f'На столе осталось {candy_count} конфет...')
    current_player = player_2 if current_player == player_1 else player_1


# while candy_count > max_candy_takes:
#     print(f'\nНа столе осталось {candy_count} конфет...')
#     while True:
#         if current_player == player_1:
#             try:
#                 take_candies = int(input(f'Сколько конфет берёт {current_player} (1-{max_candy_takes}): '))
#             except ValueError:
#                 print('Введите число')
#         # компьютер прикидывается дурачком и предпоследним ходом не оставляет шансов игроку победить
#         else:
#             if (max_candy_takes + 1) < candy_count <= (max_candy_takes * 2 + 1):
#                 take_candies = abs(max_candy_takes + 1 - candy_count)
#             else:
#                 take_candies = randint(1, max_candy_takes)
#             print(f'{current_player} берёт {take_candies} конфет')
#         if 1 <= take_candies <= max_candy_takes:  # проверка, что игрок взял разрешенное количество конфет
#             break
#     candy_count -= take_candies
#     current_player = player_2 if current_player == player_1 else player_1
# print(f'{current_player} забрал последние {candy_count} конфет и ПОБЕДИЛ!')
# print(f'{current_player} получает все конфеты {player_2 if current_player == player_1 else player_1}')


conv_handler = ConversationHandler(
    entry_points=[CommandHandler('start', start)],
    states={
        PLAYER: [MessageHandler(Filters.text, player_name)],
        MOVE: [MessageHandler(Filters.text, take_move)],
        # IS_DONE: [MessageHandler(Filters.text, edit_f)]
    },
    fallbacks=[CommandHandler('cancel', start)]
)

dispatcher.add_handler(conv_handler)

updater.start_polling()
updater.idle()
