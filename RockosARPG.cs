using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using RockosMod.Items;
using Terraria.ModLoader.IO;
namespace RockosARPG
{
	public class RockosARPG : Mod
	{
		private double pressedRandomBuffHotKeyTime1;
		private double pressedRandomBuffHotKeyTime2;
		private double pressedRandomBuffHotKeyTime3;
		//RockosPlayer Rockosplayer = new RockosPlayer();


		/*public override void SetModInfo(out string name, ref ModProperties properties)
		{
			name = "Rockos ARPG";
			properties.Autoload = true;
			properties.AutoloadGores = true;
			properties.AutoloadSounds = true;
		}*/
		
		public RockosARPG ()
		{
			//Properties = new ModProperties()
			//	{
			//		Autoload = true,
			//		AutoloadGores = true,
			//		AutoloadSounds = true
			//	};
		}
		
		public override void Load()
		{

			
			//Mod.AddGlobalItem("a",Main.item);
		}

		public override void Unload()
		{

		}

		/*public override void AddCraftGroups()
		{

		}*/

		public override void AddRecipes()
		{

		}

		public void HotKeyPressed()
		{
			if (RockosSystem.QuickHealhKeybind.JustPressed)
			{
				if (Math.Abs(Main.time - pressedRandomBuffHotKeyTime1) > 20)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					pressedRandomBuffHotKeyTime1 = Main.time;
					Rockosplayer.PreQuickHeal(Main.player[Main.myPlayer]);
				}
			}
			if (RockosSystem.QuickManaKeybind.JustPressed)
			{
				if (Math.Abs(Main.time - pressedRandomBuffHotKeyTime2) > 20)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					pressedRandomBuffHotKeyTime2 = Main.time;
					Rockosplayer.PreQuickMana(Main.player[Main.myPlayer]);
				}
			}
			if (RockosSystem.FullMenuKeybind.JustPressed)
			{
				if (Math.Abs(Main.time - pressedRandomBuffHotKeyTime3) > 20)
				{
					RockosPlayer Rockosplayer = Main.player[Main.myPlayer].GetModPlayer<RockosPlayer>();
					pressedRandomBuffHotKeyTime3 = Main.time;
					Rockosplayer.hotkeyMenu();
				}
			}
		}
	}
}