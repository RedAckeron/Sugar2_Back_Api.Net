using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
	public class TextColor
	{
		public string Msg { get; set; }
		public string Color { get; set; }
		public string Controller{ get; set; }
		public string Verbe { get; set; }
		public TextColor(string controller,string verbe,string msg, string color)
		{
			Msg = msg;
			Color = color;
			Controller = controller;
			Verbe = verbe;
		}
		



		public void Write(string ctrl,string verb,string text,string color)
		{

			switch (ctrl.ToLower())
			{

			case "user":Controller = "║USER      ║"; break;
			case "customer": Controller = "║CUSTOMER  ║"; break;
			case "item": Controller = "║ITEM      ║"; break;
			case "cmd": Controller = "║COMMAND   ║"; break;
			case "odp": Controller = "║ODP       ║"; break;

				default:
				{
					if (ctrl.Length <= 10)
					{
						Controller = "║" + ctrl;
						for (int i = ctrl.Length; i < 10; i++) ctrl += " ";
						Controller += ("║");
					}
					else
					{
						Controller = "║" + ctrl.Substring(0, 10) + "║";
					}
				} break;
			}

			switch (verb.ToLower())
			{
				case "create": Verbe = "CREATE      ║"; break;
				case "read": Verbe = "READ        ║"; break;
				case "update": Verbe = "UPDATE      ║"; break;
				case "delete": Verbe = "DELETE      ║"; break;
                case "login": Verbe = "LOGIN       ║"; break;
                case "findcustomer": Verbe = "FINDCUSTOMER║"; break;

                default: Verbe = "UNKNOWN   ║"; break;
			}

			switch (color.ToLower())
			{
				case "red": Console.BackgroundColor = ConsoleColor.Red; break;
				case "green": Console.BackgroundColor = ConsoleColor.DarkGreen; break;
				case "orange": Console.BackgroundColor = ConsoleColor.DarkYellow; break;
                case "magenta": Console.BackgroundColor = ConsoleColor.Magenta; break;
                default: Console.BackgroundColor = ConsoleColor.Yellow;break;
			}
			Console.Write(" ");
			Console.BackgroundColor = ConsoleColor.Black; 
			Console.WriteLine(Controller+Verbe+text);
		}
	}
}
