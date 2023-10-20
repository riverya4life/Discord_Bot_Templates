using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace DiscordBot
{
     class Program
     {
         private DiscordSocketClient_client;
        
         static void Main(string[] args)
         => new Program().MainAsync().GetAwaiter().GetResult();

         public async Task MainAsync()
         {
             _client = new DiscordSocketClient();

             _client.Log += Log;

             string token = "YOUR_BOT_TOKEN"; // Replace YOUR_BOT_TOKEN with your Discord bot token

             await _client.LoginAsync(TokenType.Bot, token);
             await_client.StartAsync();

             _client.MessageReceived += MessageReceived;

             // Wait to prevent the console from closing
             await Task.Delay(-1);
         }

         private async Task MessageReceived(SocketMessage message)
         {
             if (message.Content == "!hello")
             {
                 await message.Channel.SendMessageAsync("Hi, I'm a bot!");
             }
         }

         private Task Log(LogMessage msg)
         {
             Console.WriteLine(msg.ToString());
             return Task.CompletedTask;
         }
     }
}
