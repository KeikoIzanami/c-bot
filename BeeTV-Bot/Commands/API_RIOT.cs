using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeTV_Bot.Commands
{
    public class API_RIOT : BaseCommandModule
    {
        [Command("RiotAPI")]
        public async Task RiotAPICommand(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Hello");
        }
    }
}
