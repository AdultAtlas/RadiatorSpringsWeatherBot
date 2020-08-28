//Main

using System;
using System.Threading.Tasks;
using DSharpPlus;

namespace RadiatorSpringsWeatherBot
{
    class Program
    {
        private static DiscordClient _discord;
        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {
            _discord = new DiscordClient(new DiscordConfiguration
            {
                Token = System.IO.File.ReadAllText(@"C:\weatherbot\secret.txt"),
                TokenType = TokenType.Bot
            });

            _discord.MessageCreated += async e =>
            {
                NWSRequest testReq = new NWSRequest();
                if (e.Message.Content.ToLower().StartsWith("req debug"))
                    await e.Message.RespondAsync(testReq.WhichResponse(0));
                else if (e.Message.Content.ToLower().StartsWith("req forecast"))
                    await e.Message.RespondAsync(testReq.WhichResponse(1));
            };

            await _discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}