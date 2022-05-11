using System;

namespace MCGalaxy 
{
	public class CmdReadTextFile : Command
	{
		public override string name { get { return "ReadTextFile"; } }
		public override string shortcut { get { return ""; } }
		public override string type { get { return "other"; } }
		public override bool museumUsable { get { return true; } }
		public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }
		public override void Use(Player p, string message)
		{
			string text = System.IO.File.ReadAllText(@"txt.txt");
			p.Message(text);
		}

		// This is for when a player does /Help Mcgalaxy
		public override void Help(Player p)
		{
			p.Message("%T/ReadTextFile - %HReads a text file.");
		}
	}
}