import discord
from discord.ext import commands

TOKEN = 'YOUR_DISCORD_BOT_TOKEN' # You need to replace 'YOUR_DISCORD_BOT_TOKEN' with your bot token

bot = commands.Bot(command_prefix='!')

@bot.event
async def on_ready():
     print(f'Logged in as {bot.user.name}')

@bot.command()
async def hello(ctx):
     await ctx.send(f'Hello, {ctx.author.name}!')

bot.run(TOKEN)
