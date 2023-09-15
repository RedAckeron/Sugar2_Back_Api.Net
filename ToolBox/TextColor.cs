using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Models;
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
            Controller = ctrl;
			Verbe = verb;

            if (Controller.Length <= 18)
            {
                for (int i = Controller.Length; i < 18; i++) Controller += " ";
            }
            else
            {
                Controller = Controller.Substring(0, 18);
            }

            if (Verbe.Length <= 18)
            {
                for (int i = Verbe.Length; i < 18; i++) Verbe += " ";
            }
            else
            {
                Verbe = Verbe.Substring(0, 18);
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
			Console.WriteLine("║" + Controller.ToUpper()+ "║" + Verbe.ToUpper()+"║" + text);
		}
	}
}
