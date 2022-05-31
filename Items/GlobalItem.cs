using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RockosARPG;

namespace RockosMod.Items
{
	public class GlobalItems : GlobalItem
	{
		public override bool CanUseItem(Item item, Player player)
		{
			RockosPlayer Rockosplayer = player.GetModPlayer<RockosPlayer>();
			if(Rockosplayer.optionouvert || Rockosplayer.fullmenuouvert || Rockosplayer.skillouvert)return false;
			return true;
		}

		public override bool CanConsumeAmmo(Item item, Player player)
		{
			RockosPlayer Rockosplayer = player.GetModPlayer<RockosPlayer>();
			if(Main.rand.Next(100) <= Rockosplayer.skillNoWaste)
			{
				return false;
			}
			return true;
		}
	}
}