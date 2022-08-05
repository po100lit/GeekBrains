from telegram import Update, Bot
from telegram.ext import Updater, CommandHandler, Filters, MessageHandler
import os

bot = Bot(token=os.getenv('TOKEN'))
updater = Updater(token=os.getenv('TOKEN'))
dispatcher = updater.dispatcher


def add(update, context):
    arg = context.args
    try:
        res = sum(map(int, arg))
        context.bot.send_message(update.effective_chat.id, f'{" + ".join(map(str, arg))} = {res}')
    except ValueError:
        context.bot.send_message(update.effective_chat.id, 'Enter numbers')


def start(update, context):
    arg = context.args
    if not arg:
        context.bot.send_message(update.effective_chat.id, "Привет")
    else:
        context.bot.send_message(update.effective_chat.id, f"{' '.join(arg)}")


def info(update, context):
    context.bot.send_message(update.effective_chat.id, "I'm Batman")


def message(update, context):
    text = update.message.text
    if text.lower() == 'привет':
        context.bot.send_message(update.effective_chat.id, 'И тебе привет..')
    else:
        context.bot.send_message(update.effective_chat.id, 'я тебя не понимаю')


def unknown(update, context):
    context.bot.send_message(update.effective_chat.id, f'Шо сказал, не пойму')

add_handler = CommandHandler('add', add)
start_handler = CommandHandler('start', start)  # /start фразочка
info_handler = CommandHandler('info', info)  # /info
message_handler = MessageHandler(Filters.text, message)
unknown_handler = MessageHandler(Filters.command, unknown)  # /game

dispatcher.add_handler(add_handler)
dispatcher.add_handler(start_handler)
dispatcher.add_handler(info_handler)
dispatcher.add_handler(unknown_handler)
dispatcher.add_handler(message_handler)

print('server started')
updater.start_polling()
updater.idle()
