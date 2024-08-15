using CommandSystem;
using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcandc.Commands
{
	[CommandHandler(typeof(ClientCommandHandler))]
	public class bc : ICommand
	{
		
		public string Command { get; } = "bc";

	
		public string[] Aliases { get; } = new string[]
		{
			"bc"
		};

	
		public string Description { get; } = "Global Chat Commands-全体聊天";

		public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
		{
			Player player = Player.Get(sender);
			string text = "";

			if (arguments.Count == 0)
			{
				response = "没有文字";
				return false;
			}
			foreach (string txt in arguments)
		    {
					text = text + ""+ txt;
			}
			Map.Broadcast((ushort)Plugin.Ins.Config.Bctime, Plugin.Ins.Config.BcText.Replace("tcolor", player.Role.Team.GetColor()).Replace("name", player.Nickname).Replace("mes",text));
			response = "发送成功！";
			return true;
		}
	}
}
