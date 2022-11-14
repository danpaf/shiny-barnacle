using System;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;


class Program
    {
        static void Main(string[] args)
        {
            MainAsync(token:"MTA0MTgwOTg1NzQzMjUyNjg5OQ.GiPHha.hr06vc9ivmWkATrsmYCsi4uAJJJHLmTRUeUA1Y").GetAwaiter().GetResult();
        }

        private string prefix;
        static async Task MainAsync(string token)
        {
            var discord = new DiscordClient(new DiscordConfiguration()
            {
                Token = token,
                TokenType = TokenType.Bot,
                
            });
            var commands = discord.UseCommandsNext(new CommandsNextConfiguration());
            commands.RegisterCommands<commandsSlash>();
            new CommandsNextConfiguration()
            {
                StringPrefixes = new[] {"/"}
            };

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
