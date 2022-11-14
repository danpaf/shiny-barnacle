using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

public class commandsSlash : BaseCommandModule
{
    [Command("greet")]
    public async Task GreetCommand(CommandContext ctx)
    {
        await ctx.RespondAsync("Greetings! Thank you for executing me!");
    }
}