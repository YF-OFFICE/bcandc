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
	public class c : ICommand
	{

		public string Command { get; } = "c";


		public string[] Aliases { get; } = new string[]
		{
			"c"
		};


		public string Description { get; } = "Team Chat Commands-团队打字";

		public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
		{
			Player player = Player.Get(sender);
			string text = "";

			if (arguments.Count == 0)
			{
				response = "没有文本";
				return false;
			}
			foreach (string txt in arguments)
			{
				text = text +""+ txt;
			}
			foreach (Player player1 in Player.List)
			{
				if (player1.Role.Team == player.Role.Team)
				{

					player1.Broadcast((ushort)Plugin.Ins.Config.ctime, Plugin.Ins.Config.cText.Replace("tcolor", player.Role.Team.GetColor()).Replace("rname", player.Role.Type.GetRolename()).Replace("name", player.Nickname).Replace("mes",text)) ;

				}
			
			}
			

			response = "发送成功";
			return true;
		}
	}
}
